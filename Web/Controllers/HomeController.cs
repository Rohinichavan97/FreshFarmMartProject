using Core;
using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mono.TextTemplating;
using System.Numerics;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IProductRepo productRepo;
        IMainCategoryRepo mainCategoryRepo;
        ICategoryRepo catrepo;
        ICountryRepo ctrepo;
        IStateRepo srepo;
        ICityRepo cityrepo;
        ISearchProductRepo searchrepo;
        IProductReviewRepo productReviewRepo;
        public HomeController(IProductRepo productRepo, IMainCategoryRepo mainCategoryRepo, ICategoryRepo catrepo, ICountryRepo ctrepo,
            IStateRepo srepo, ICityRepo cityrepo, ISearchProductRepo searchProductRepo, IProductReviewRepo productReviewRepo)
        {

            this.productRepo = productRepo;
            this.mainCategoryRepo = mainCategoryRepo;
            this.catrepo = catrepo;
            this.ctrepo = ctrepo;
            this.srepo = srepo;
            this.cityrepo = cityrepo;
            this.searchrepo = searchProductRepo;
            this.productReviewRepo = productReviewRepo;

        }
        public JsonResult GetStates(Int64 CountryID)
        {
            var res = this.srepo.GetStatesByCountryID(CountryID);
            return Json(res);
        }
        public JsonResult GetCities(Int64 stateid)
        {
            var res = this.cityrepo.GetCitiesByStateID(stateid);
            return Json(res);
        }

        [HttpGet]
        public JsonResult GetCategories(Int64 MainCategoryID)
        {
            var res = this.catrepo.GetCategoryByMainCategoryID(MainCategoryID);
            return Json(res);
        }


        [HttpGet]
        public IActionResult Index()
        {
            // Fetching SelectList data for dropdowns
            ViewBag.MainCategoryID = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            ViewBag.CategoryID = new SelectList(this.catrepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.CountryID = new SelectList(this.ctrepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            ViewBag.CityID = new SelectList(this.cityrepo.GetAll(), "CityID", "CityName");

            // Map Product entities to GetProductVM
            var productList = this.productRepo.GetAll()
                .Select(product => new GetProductVM
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ProductDesc = product.ProductDesc,
                    CategoryName = product.Category.CategoryName, // Assuming Category has a Name
                    UnitName = product.Unit.UnitName,             // Assuming Unit has a Name
                    Qty = product.Qty,
                    Price = product.Price,
                    MainPhotoPath = product.MainPhotoPath,
                    TradeName = product.TraderFarmer.TradeName   // Assuming TraderFarmer has a Name
                }).ToList();

            // Initializing model and setting the mapped product list
            SearchProductVM model = new SearchProductVM
            {
                ProductDataVM = productList
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Index(SearchProductVM searchProductVM)
        {

            ViewBag.MainCategoryID = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            ViewBag.CategoryID = new SelectList(this.catrepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.CountryID = new SelectList(this.ctrepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.srepo.GetAll(), "StateID", "StateName");
            ViewBag.CityID = new SelectList(this.cityrepo.GetAll(), "CityID", "CityName");

            SearchProductVM model = new SearchProductVM();
            model.ProductDataVM = this.searchrepo.GetProducts(searchProductVM);
            //var Category = this.catrepo.GetCategoryByMainCategoryID(model.MainCategoryID);

            return View(model);
        }
        public IActionResult About()
        {
            
            return View();
        }


        public IActionResult GetProducts(Int64 CategoryID = 0)
        {
            if (CategoryID == 0)
            {
                var res = this.productRepo.GetAll();
                return View(res);
            }
            else
            {
                var res = this.productRepo.GetProductsByCategory(CategoryID);
                return View(res);
            }
        }

        public IActionResult GetReviews(Int64 id)
        {
            var rec = this.productReviewRepo.GetProductReviewsByProductID(id);
            ViewBag.ProductID = id;
            return View(rec);
        }
        public IActionResult Details(Int64 id)
        {
            var product = this.productRepo.GetProductDetails(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);

            
        }

    }
}
