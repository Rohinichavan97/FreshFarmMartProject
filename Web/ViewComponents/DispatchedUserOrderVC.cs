using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class DispatchedUserOrderVC : ViewComponent
    {
        IOrderRepo repo;
        public DispatchedUserOrderVC(IOrderRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.repo.AllDispatchedOrders(userid);
            return View(res);
        }


    }
}
