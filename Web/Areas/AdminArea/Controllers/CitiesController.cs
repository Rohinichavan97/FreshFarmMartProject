using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class CitiesController : Controller
    {
        IStateRepo stateRepo;
        ICountryRepo countryRepo;
        ICityRepo repo;
        public CitiesController(ICityRepo repo, IStateRepo stateRepo, ICountryRepo countryRepo)
        {
            this.repo = repo;
            this.countryRepo = countryRepo;
            this.stateRepo = stateRepo;
        }
        public JsonResult GetStates(Int64 CountryID)
        {
            var res = this.stateRepo.GetStatesByCountryID(CountryID);
            return Json(res);
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
           //ViewBag.States = new SelectList(this.stateRepo.GetAll(), "StateID", "StateName");
            return View();
        }


        [HttpPost]
        public IActionResult Create(City rec)
        {
            ViewBag.States = new SelectList(this.stateRepo.GetAll(), "StateID", "StateName");
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
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", rec.State.CountryID);
            var States = this.stateRepo.GetStatesByCountryID(rec.State.CountryID);
            ViewBag.States = new SelectList(States,"StateID", "StateName",rec.StateID);
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(City rec,Int64 country)
        {
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", country);
            var States = this.stateRepo.GetStatesByCountryID(country);
            ViewBag.States = new SelectList(States, "StateID", "StateName", rec.StateID);
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
