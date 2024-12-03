using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class NewOrderVC : ViewComponent
    {
        IOrderRepo repo;
        public NewOrderVC(IOrderRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var res = this.repo.AllNewOrders();
            return View(res);
        }
    }
}
