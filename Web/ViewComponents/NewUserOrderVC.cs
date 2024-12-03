using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class NewUserOrderVC : ViewComponent
    {
        IOrderRepo repo;
        public NewUserOrderVC(IOrderRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(Int64 userid)
        {
            var res = this.repo.AllNewOrders(userid);
            return View(res);
        }
    }
}
