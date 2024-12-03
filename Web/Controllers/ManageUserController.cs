using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class ManageUserController : Controller
    {
        IUserRepo userrepo;
        ICountryRepo countryrepo;
        IStateRepo stateRepo;
        ICityRepo cityRepo;
        public ManageUserController(IUserRepo userrepo ,ICountryRepo countryRepo, IStateRepo stateRepo, ICityRepo cityRepo)
        {
            this.userrepo = userrepo;
            this.countryrepo = countryRepo;
            this.stateRepo = stateRepo;
            this.cityRepo = cityRepo;
        }
       
        [HttpGet]
        public IActionResult Login()
        
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.userrepo.Login(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("UserID", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("UserName", res.LoggedInName);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid  Email Id or Password");
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Countries = new SelectList(this.countryrepo.GetAll(), "CountryID", "CountryName");
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
		public IActionResult Register(UserVM rec,Int64 state)
		{
			ViewBag.Countries = new SelectList(this.countryrepo.GetAll(), "CountryID", "CountryName");
			if (ModelState.IsValid) {
				var res = this.userrepo.Register(rec);
				if (res.IsSuccess) {
					return RedirectToAction("Login");
				}
				ModelState.AddModelError("", res.Message);
			}
			return View(rec);
		}
        public IActionResult LogOut()
        {
            
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            
        }
    }
}
