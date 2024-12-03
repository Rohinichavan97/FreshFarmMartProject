using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ManageAdminController : Controller
    {
        private readonly IAdminRepo _AdminRepo;
        public ManageAdminController(IAdminRepo AdminRepo)
        {
            this._AdminRepo = AdminRepo;
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
                var res = this._AdminRepo.Login(rec);
                if (res.IsLoggedIn)
                {
                    HttpContext.Session.SetString("AdminId", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("FullName", res.LoggedInName);
                    return RedirectToAction("Index", "AdminHome", new { area = "AdminArea" });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email Id or Password!");
                }

            }
            return View(rec);
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }
    }
}
