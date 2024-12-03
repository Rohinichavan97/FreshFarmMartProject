using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class FarmerController : Controller
    {

        ITraderFarmerRepo frepo;
        ICountryRepo countryrepo;
        IStateRepo stateRepo;
        ICityRepo cityRepo;
        public FarmerController(ITraderFarmerRepo frepo, ICountryRepo countryrepo, IStateRepo stateRepo, ICityRepo cityRepo)
        {
            this.frepo = frepo;
            this.countryrepo = countryrepo;
            this.stateRepo = stateRepo;
            this.cityRepo = cityRepo;
        }
        [HttpGet]
        public IActionResult Login()

        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(FarmerLoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.frepo.Login(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("TraderFarmerID", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("TradeName", res.LoggedInName);
                   // HttpContext.Session.SetString("EmailID", res.LoggedEmailId);
                    return RedirectToAction("Index", "FarmerHome", new { area = "FarmerArea" });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Mobile No Id or Password!");
                }

            }
            return View(rec);
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Countries = new SelectList(this.countryrepo.GetAll(), "CountryID", "CountryName");
            ViewBag.States = new SelectList(this.stateRepo.GetAll(), "StateID", "StateName");
            ViewBag.Cities = new SelectList(this.cityRepo.GetAll(), "CityID", "CityName");
            return View();
        }

        [HttpGet]
        public JsonResult GetStates(Int64 countryid)
        {
            var res = this.stateRepo.GetStatesByCountryID(countryid);
            return Json(res);
        }

        [HttpGet]
        public JsonResult GetCities(Int64 stateid)
        {
            var res = this.cityRepo.GetCitiesByStateID(stateid);
            return Json(res);
        }


        [HttpPost]
        public IActionResult Register(FarmerVM rec,Int64 state)
        {
            ViewBag.Countries = new SelectList(this.countryrepo.GetAll(), "CountryID", "CountryName");
            ViewBag.States = new SelectList(this.stateRepo.GetAll(), "StateID", "StateName");
            ViewBag.Cities = new SelectList(this.cityRepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                var res = this.frepo.Register(rec);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Login");
                }
                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }
    }
}
