using Core;
using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class FarmerHomeController : Controller
    {
        ITraderFarmerRepo FRepo;
        public FarmerHomeController(ITraderFarmerRepo FRepo)
        {
            this.FRepo = FRepo;
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
                Int64 id = Convert.ToInt64(HttpContext.Session.GetString("TraderFarmerID"));
                var res = this.FRepo.ChangePassword(rec, id);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            Int64 TraderFarmerID = Convert.ToInt64(HttpContext.Session.GetString("TraderFarmerID"));
            var rec = this.FRepo.GetFarmerProfile(TraderFarmerID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(AdminProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 TraderFarmerID = Convert.ToInt64(HttpContext.Session.GetString("TraderFarmerID"));
                var res = this.FRepo.EditProfile(rec, TraderFarmerID);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
