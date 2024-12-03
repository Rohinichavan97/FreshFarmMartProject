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

    public class ProductPhotoController : Controller
    {
        IProductRepo ProductRepo;
        IProductPhotoRepo repo;
        IWebHostEnvironment env;
        public ProductPhotoController(IProductPhotoRepo repo, IWebHostEnvironment env, IProductRepo ProductRepo)

        {
            this.repo = repo;
            this.env = env;
            this.ProductRepo = ProductRepo;

        } 
        public IActionResult Index()
        {
            var res = this.repo.GetAll();
            return View(res);
           
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Products = new SelectList(this.ProductRepo.GetAll(), "ProductID", "ProductName");
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductPhoto rec)
        {
            ViewBag.Products = new SelectList(this.ProductRepo.GetAll(), "ProductID", "ProductName");
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
                            rec.PhotoPath = Path.Combine(@"\ProductPhotos", rec.PhotoFile.FileName);
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
                    this.repo.Add(rec);
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
            var rec = this.repo.GetById(id);
            ViewBag.Products = new SelectList(this.ProductRepo.GetAll(), "ProductID", "ProductName",rec.ProductID);
            return View(rec);

        }


        [HttpPost]
        public IActionResult Edit(ProductPhoto rec)
        {
            ViewBag.Products = new SelectList(this.ProductRepo.GetAll(), "ProductID", "ProductName", rec.ProductID);
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
                            rec.PhotoPath = Path.Combine(@"\ProductPhotos", rec.PhotoFile.FileName);
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
                   // this.repo.Update(rec);
                  //  this.repo.ProductPhotos(rec);

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
        public IActionResult Delete(Int64 id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
