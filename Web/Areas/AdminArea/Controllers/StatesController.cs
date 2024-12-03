using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class StatesController : Controller
    {
        IStateRepo repo;
        ICountryRepo countryRepo;
        public StatesController(IStateRepo repo, ICountryRepo countryRepo)
        {
            this.repo = repo;
            this.countryRepo = countryRepo;
        }

        public IActionResult Index()
        {
            var res = this.repo.GetAll();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName");
            return View();
        }


        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName");
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
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", rec.CountryID);
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", rec.CountryID);
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
