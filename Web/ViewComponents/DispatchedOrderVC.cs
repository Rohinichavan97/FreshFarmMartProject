using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class DispatchedOrderVC : ViewComponent
    {
        IOrderRepo repo;
        public DispatchedOrderVC(IOrderRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var res = this.repo.AllDispatchedOrders();
            return View(res);
        }
    }
}
