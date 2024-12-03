using Core.Enum;

using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class WishListController : Controller
    {
        IWishListRepo WishListRepo;
        public WishListController(IWishListRepo WishListRepo)
        {
            this.WishListRepo = WishListRepo;
        }
        public IActionResult AddToWishList(Int64 pid, Int64 catid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            if (!WishListRepo.Exists(userid, pid))
            {

                var res = this.WishListRepo.AddToWisthList(userid, pid);
                TempData["Message"] = res.Message;
            }
            else
            {
                TempData["Message"] = "Product Already in Wish List!";
            }
            //return View();
            return RedirectToAction("Index", "Home", new { CatID = catid });
        }

        public IActionResult GetList()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));

            var res = this.WishListRepo.GetWisthListByUserID(userid);
            return View(res);
        }
    }
}
