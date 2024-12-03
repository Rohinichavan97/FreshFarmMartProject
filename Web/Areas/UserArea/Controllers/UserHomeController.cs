using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuth]

    public class UserHomeController : Controller
    {
        IUserRepo userRepo;
        ICountryRepo countryRepo;
        IStateRepo stateRepo;
        ICityRepo cityRepo;
        public UserHomeController(IUserRepo userRepo, ICountryRepo countryRepo, IStateRepo stateRepo, ICityRepo cityRepo)
        {
            this.userRepo = userRepo;
            this.countryRepo = countryRepo;
            this.stateRepo = stateRepo;
            this.cityRepo = cityRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ChangePassword(ChangePasswodVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 id = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.userRepo.ChangePassword(rec, id);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult Edit()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec = this.userRepo.GetUserProfile(userid);
            var city = this.cityRepo.GetById(rec.CityID);
           
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", city.State.Country.CountryID);

            ViewBag.States = new SelectList(this.stateRepo.GetStatesByCountryID(city.State.CountryID), "StateID", "StateName", city.State.StateID);

            ViewBag.Cities = new SelectList(this.cityRepo.GetCitiesByStateID(city.StateID), "CityID", "CityName", rec.CityID);

            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(UserProfileVM rec)
        {
            var city = this.cityRepo.GetById(rec.CityID);
            ViewBag.Countries = new SelectList(this.countryRepo.GetAll(), "CountryID", "CountryName", city.State.Country.CountryID);

            ViewBag.States = new SelectList(this.stateRepo.GetStatesByCountryID(city.State.CountryID), "StateID", "StateName", city.State.StateID);

            ViewBag.Cities = new SelectList(this.cityRepo.GetCitiesByStateID(city.StateID), "CityID", "CityName", rec.CityID);


            if (ModelState.IsValid)
            {
                Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.userRepo.EditProfile(rec, userid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
