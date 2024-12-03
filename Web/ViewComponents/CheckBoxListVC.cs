using Infra.Repositories;
using Infra.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class CheckBoxListVC : ViewComponent
    {

        IProductAndProductDiscountRepo rp;
        public CheckBoxListVC(IProductAndProductDiscountRepo rp)
        {

            this.rp = rp;
        }
        public IViewComponentResult Invoke(ProductAndProductDiscountVM model = null)
        {
            if (model != null)
            {
                return View(model);
            }
            return View(new ProductAndProductDiscountVM());
        }
    }
}
