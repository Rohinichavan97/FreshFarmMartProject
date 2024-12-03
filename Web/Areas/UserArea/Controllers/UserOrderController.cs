using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]
    public class UserOrderController : Controller
    {
        IOrderRepo repo;
        IProductRepo productRepo;
        IProductReviewRepo productReviewRepo;
        public UserOrderController(IOrderRepo repo, IProductRepo productRepo, IProductReviewRepo productReviewRepo)
        {
            this.repo = repo;
            this.productRepo = productRepo;
            this.productReviewRepo = productReviewRepo;
        }
       
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult ViewOrder(Int64 id)
        {
            var rec = this.repo.GetOrderByID(id);
            return View(rec);
        }


        [HttpGet]
        public IActionResult AddReview(Int64 id)
        {
            var prod = this.productRepo.GetById(id);
            ViewBag.ProductID = id;
            ViewBag.ProductName = prod.ProductName;
            ViewBag.ProductDesc = prod.ProductDesc;
            ViewBag.Price = prod.Price;
            ViewBag.MainPhotoPath = prod.MainPhotoPath;
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(ProductReview rec)
        {
            var prod = this.productRepo.GetById(rec.ProductID);
            ViewBag.ProductID = prod.ProductID;
            ViewBag.ProductName = prod.ProductName;
            ViewBag.ProductDesc = prod.ProductDesc;
            ViewBag.Price = prod.Price;
            ViewBag.MainPhotoPath = prod.MainPhotoPath;
            if (ModelState.IsValid)
            {
                Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                rec.UserID = userid;
                this.productReviewRepo.Add(rec);
                return RedirectToAction("Index", "Home", new {area=""});
            }
            return View(rec);
        }
    }
}
