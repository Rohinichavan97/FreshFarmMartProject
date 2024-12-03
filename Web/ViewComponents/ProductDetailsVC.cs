using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class ProductDetailsVC: ViewComponent
    {
        IProductRepo repo;
        public ProductDetailsVC(IProductRepo repo)
        {
            this.repo = repo;
        }
        public IViewComponentResult Invoke(Int64 productid)
        {
            var rec = this.repo.GetById(productid);
            return View(rec);
        }

    }
}
