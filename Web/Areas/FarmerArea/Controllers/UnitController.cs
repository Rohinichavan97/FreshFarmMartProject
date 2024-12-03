using Core;
using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using Web.CustFilter;

namespace Web.Areas.FarmerArea.Controllers
{
    [Area("FarmerArea")]
    [FarmerAuth]
    public class UnitController : Controller
    {
        IUnitRepo Uepo;
        public UnitController(IUnitRepo Uepo)

        {
            this.Uepo = Uepo;

        }
        public IActionResult Index()
        {
            var res = this.Uepo.GetAll();
            return View(res);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Unit rec)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    this.Uepo.Add(rec);
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
            var rec = this.Uepo.GetById(id);

            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(Unit rec)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    this.Uepo.Update(rec);
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
            this.Uepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
