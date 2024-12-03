using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class CartCountVC:ViewComponent
    {
        ICartRepo repo;
        public CartCountVC(ICartRepo repo)
        {
            this.repo = repo;
        }
        public IViewComponentResult Invoke(Int64 userid = 0)
        {
            var cnt = this.repo.GetCartCount(userid);
            return View(cnt);
        }
    }
}
