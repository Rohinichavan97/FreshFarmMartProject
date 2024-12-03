using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class MainCategoryController : Controller
    {
     
        IMainCategoryRepo repo;
        public MainCategoryController(IMainCategoryRepo repo)

        {
            this.repo = repo;
           
        }
        public IActionResult Index()
        {
            var res = this.repo.GetAll();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(MainCategory rec)
        {
            
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
          
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(MainCategory rec)
        {
           
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
