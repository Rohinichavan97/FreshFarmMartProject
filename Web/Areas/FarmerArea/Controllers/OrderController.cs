using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    //[FarmerAuth]
    public class OrderController : Controller
    {
        IOrderRepo repo;
        IDispatchAgencyRepo drepo;
        public OrderController(IOrderRepo repo, IDispatchAgencyRepo drepo)
        {
            this.repo = repo;
            this.drepo = drepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewOrder(Int64 id)
        {
            var rec = this.repo.GetOrderByID(id);
            return View(rec);
        }

        [HttpGet]
        public IActionResult DispatchOrder(Int64 id)
        {
            ViewBag.UserOrderID = id;
            ViewBag.DispatchAgencies = new SelectList(this.drepo.GetAll(), "DispatchAgencyID", "AgencyName");
            return View();
        }

        [HttpPost]
        public IActionResult DispatchOrder(OrderDispatch rec)
        {

            ViewBag.DispatchAgencies = new SelectList(this.drepo.GetAll(), "DispatchAgencyID", "AgencyName");

            if (ModelState.IsValid)
            {
                var res = this.repo.DispatchOrder(rec);
                if (res.IsSuccess)
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", res.Message);
            }
            return View(rec);
        }
    }
}
