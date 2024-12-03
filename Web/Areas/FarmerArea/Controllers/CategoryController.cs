using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class CategoryController : Controller
    {
        ICategoryRepo repo;
        IMainCategoryRepo mainCategoryRepo;
        public CategoryController(ICategoryRepo repo, IMainCategoryRepo mainCategoryRepo)

        {
            this.repo = repo;
            this.mainCategoryRepo = mainCategoryRepo;
        }
        public IActionResult Index()
        {
            var res = this.repo.GetAll();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MainCategories = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category rec)
        {
            ViewBag.MainCategories = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            if (ModelState.IsValid)
            {
                try
                {
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
            ViewBag.MainCategories = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(Category rec)
        {
            ViewBag.MainCategories = new SelectList(this.mainCategoryRepo.GetAll(), "MainCategoryID", "MainCategoryName");
            if (ModelState.IsValid)
            {
                try
                {
                    this.repo.Update(rec);
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
