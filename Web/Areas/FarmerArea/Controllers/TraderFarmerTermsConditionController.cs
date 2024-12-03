using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class TraderFarmerTermsConditionController : Controller
    {
        ITraderFarmerTermsConditionRepo tcrpo;
        public TraderFarmerTermsConditionController(ITraderFarmerTermsConditionRepo tcrpo)

        {
            this.tcrpo = tcrpo;

        }
        public IActionResult Index()
        {
            var res = this.tcrpo.GetAll();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(TraderFarmerTermsCondition rec)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    this.tcrpo.Add(rec);
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
            var rec = this.tcrpo.GetById(id);

            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(TraderFarmerTermsCondition rec)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    this.tcrpo.Update(rec);
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
            this.tcrpo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
