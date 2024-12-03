using Core;
using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class ProductController : Controller
    {
        IProductAndProductDiscountRepo drepo;
        IProductRepo productrepo;
        ICategoryRepo repo;
        IMainCategoryRepo mainCategoryRepo;
        IWebHostEnvironment env;
        IUnitRepo urpo;
        ITraderFarmerRepo frepo;
        public ProductController(IProductAndProductDiscountRepo drepo,IProductRepo productrepo,ICategoryRepo repo, IMainCategoryRepo mainCategoryRepo, IWebHostEnvironment env, IUnitRepo urpo,ITraderFarmerRepo frepo)

        {
            this.drepo = drepo;
            this.productrepo = productrepo;
            this.repo = repo;
            this.mainCategoryRepo = mainCategoryRepo;
            this.env = env;
            this.urpo = urpo;
            this.frepo = frepo;
        }
        public IActionResult Index()
        {
            var res = this.productrepo.GetAll();
            return View(res);
        }


        [HttpGet]
        public JsonResult GetCategories(Int64 MainCategoryID)
        {
            var res = this.repo.GetCategoryByMainCategoryID(MainCategoryID);
            return Json(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(this.repo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.Units = new SelectList(this.urpo.GetAll(), "UnitID", "UnitName");
            ViewBag.TraderFarmers = new SelectList(this.frepo.GetAll(), "TraderFarmerID", "TradeName");

            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductAndProductDiscountVM rec, Int64[] chk)
        {
            ViewBag.Categories = new SelectList(this.repo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.Units = new SelectList(this.urpo.GetAll(), "UnitID", "UnitName");
            ViewBag.TraderFarmers = new SelectList(this.frepo.GetAll(), "TraderFarmerID", "TradeName");


            if (ModelState.IsValid)
            {
                try
                {
                    if (rec.PhotoFile != null)
                    {
                        if (rec.PhotoFile.Length > 0)
                        {
                            string folderpath = Path.Combine(env.WebRootPath, "ProductPhotos");
                            string path = Path.Combine(folderpath, rec.PhotoFile.FileName);

                            FileStream fs = new FileStream(path, FileMode.Create);
                            rec.PhotoFile.CopyTo(fs);
                            rec.MainPhotoPath = Path.Combine(@"\ProductPhotos", rec.PhotoFile.FileName);
                        }
                        else
                        {
                            ModelState.AddModelError("PhotoFile", "Please Select File having > 1 byte");
                            return View(rec);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Please Select File Upload");
                        return View(rec);
                    }

                    //this.repo.Add(rec);



                    this.drepo.ProductDiscounts(rec,chk);

                   
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.ToString());
                    return View(rec);
                }
            }
            return View(rec);
        }



        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ProductAndProductDiscountVM model = GetProductAndProductDiscountVMData(id);

            ViewBag.Categories = new SelectList(this.repo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.Units = new SelectList(this.urpo.GetAll(), "UnitID", "UnitName");
            ViewBag.TraderFarmers = new SelectList(this.frepo.GetAll(), "TraderFarmerID", "TradeName");

            return View(model);
        }

        public ProductAndProductDiscountVM GetProductAndProductDiscountVMData(Int64 id)
        {
            ProductAndProductDiscountVM model = new ProductAndProductDiscountVM();

            Product objProduct = this.productrepo.GetById(id);
            ProductDiscount productDiscount = objProduct.ProductDiscounts.FirstOrDefault();

            if (objProduct != null)
            {
                model.CategoryID = objProduct.CategoryID;
                model.ProductDesc = objProduct.ProductDesc;
                model.ProductName = objProduct.ProductName;
                model.TraderFarmerID = objProduct.TraderFarmerID;
                model.MainPhotoPath = objProduct.MainPhotoPath;
                model.ProductID = objProduct.ProductID;
                model.UnitID = objProduct.UnitID;
                model.Qty = objProduct.Qty;
                model.Price = objProduct.Price;
                model.DiscountAmount = productDiscount.DiscountAmount;
                model.DiscountName = productDiscount.DiscountName;
                model.TradeName = objProduct.TraderFarmer.TradeName;
            }

            return model;
        }


        [HttpPost]
        public IActionResult Edit(ProductAndProductDiscountVM rec, Int64 CategoryID)
        {
            ViewBag.Categories = new SelectList(this.repo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.Units = new SelectList(this.urpo.GetAll(), "UnitID", "UnitName");
            ViewBag.TraderFarmers = new SelectList(this.frepo.GetAll(), "TraderFarmerID", "TradeName");


            if (ModelState.IsValid)
            {
                try
                {
                    if (rec.PhotoFile != null)
                    {
                        if (rec.PhotoFile.Length > 0)
                        {
                            string folderpath = Path.Combine(env.WebRootPath, "ProductPhotos");
                            string path = Path.Combine(folderpath, rec.PhotoFile.FileName);

                            FileStream fs = new FileStream(path, FileMode.Create);
                            rec.PhotoFile.CopyTo(fs);
                            rec.MainPhotoPath = Path.Combine(@"\ProductPhotos", rec.PhotoFile.FileName);
                        }
                        else
                        {
                            ModelState.AddModelError("PhotoFile", "Please Select File having > 1 byte");
                            return View(rec);
                        }
                    }
                    //this.productrepo.Update(rec);
                    this.drepo.Update(rec);
                    


                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.ToString());
                    return View(rec);
                }
            }
            return View(rec);
        }

        //[HttpGet]
        //public IActionResult Delete(Int64 id)
        //{
        //    this.productrepo.Delete(id);
        //    return RedirectToAction("Index");
        //}
        [HttpGet]
        public IActionResult Details(Int64 id)
        {


            var rec = this.GetProductAndProductDiscountVMData(id);
            return View(rec);
        }


        [HttpGet]
        public IActionResult AddPhotos(long id)
        {
            var product = this.productrepo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ProductPhotoVM
            {
                ProductID = id,
                ExistingPhotos = product.ProductPhotos.Select(p => new ProductPhotoVM
                {
                    ProductPhotoID=p.ProudctPhotoID,
                    PhotoPath = p.PhotoPath
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddPhotos(long id, IFormFile newPhoto)
        {
            if (newPhoto != null && newPhoto.Length > 0)
            {
                string folderPath = Path.Combine(env.WebRootPath, "ProductPhotos");
                string filePath = Path.Combine(folderPath, newPhoto.FileName);

                // Save the new photo file
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    newPhoto.CopyTo(stream);
                }

                // Add photo to the database
                var productPhoto = new ProductPhoto
                {
                    ProductID = id,
                    PhotoPath = Path.Combine(@"\ProductPhotos", newPhoto.FileName)
                };
                this.productrepo.AddPhoto(productPhoto);
            }

            return RedirectToAction("AddPhotos", new { id });
        }

        [HttpPost]
        public IActionResult DeletePhoto(long photoId)
        {
            var photo = this.productrepo.GetPhotoById(photoId);
            if (photo != null)
            {
                string filePath = Path.Combine(env.WebRootPath, photo.PhotoPath.TrimStart('\\'));
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }

                this.productrepo.DeletePhoto(photoId);
            }

            return RedirectToAction("AddPhotos", new { id = photo.ProductID });
        }
    }
}
