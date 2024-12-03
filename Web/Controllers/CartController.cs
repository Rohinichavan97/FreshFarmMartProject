using Core.Enum;

using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CartController : Controller
    {
        ICartRepo repo;
        public CartController(ICartRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult AddToCart(Int64 productid, Int64 catid)
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));

            var res = this.repo.AddToCart(userid, productid);
            TempData["Message"] = res.Message;
            return RedirectToAction("Index", "Home", new { CatID = catid });

        }


        public IActionResult GetCart()
        {
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var cartItems = this.repo.GetCart(userid);
            return View(cartItems);
        }


        public IActionResult DeleteFromCart(Int64 cartid)
        {
            var res = this.repo.Delete(cartid);
            TempData["Message"] = res.Message;
            return RedirectToAction("GetCart");
        }

        public IActionResult MakePayment(PaymentModeEnum pmode)
        {
            if (pmode == PaymentModeEnum.Cash)
            {
                return RedirectToAction("PlaceOrder", new { pmode = pmode });
            }
            else
            {
                return RedirectToAction("PaymentGateway", new { pmode = pmode });
            }
        }

        [HttpGet]
        public IActionResult PaymentGateWay(PaymentModeEnum pmode)
        {
            ViewBag.PaymentMode = pmode;
            return View();
        }


        [HttpPost]
        public IActionResult PaymentGateWay(PaymentModeVM rec)
        {
            //code 
            return RedirectToAction("PlaceOrder", new { pmode = rec.PMode });

        }

        public IActionResult PlaceOrder(PaymentModeEnum pmode)
        {
            //find user id
            Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));

            var res = this.repo.PlaceOder(userid, pmode);
            if (res.IsSuccess)
            {
                return View("OrderSuccess", res.Message);
            }
            else
            {
                TempData["Message"] = res.Message;
                return RedirectToAction("GetCart");
            }

        }
    }
}
