using Core;
using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuth]
    public class AdminHomeController : Controller
    {
        IAdminRepo adminRepo;
        public AdminHomeController(IAdminRepo adminRepo)
        {
            this.adminRepo = adminRepo;
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
                Int64 id = Convert.ToInt64(HttpContext.Session.GetString("AdminId"));
                var res = this.adminRepo.ChangePassword(rec, id);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            Int64 AdminId = Convert.ToInt64(HttpContext.Session.GetString("AdminId"));
            var rec = this.adminRepo.GetAdminProfile(AdminId);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(AdminProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 AdminId = Convert.ToInt64(HttpContext.Session.GetString("AdminId"));
                var res = this.adminRepo.EditProfile(rec, AdminId);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
