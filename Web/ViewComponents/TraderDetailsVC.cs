using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class TraderDetailsVC: ViewComponent
    {
        IProductRepo repo;
        ITraderFarmerRepo tradrepo;
        public TraderDetailsVC(IProductRepo repo, ITraderFarmerRepo tradrepo)
        {
            this.repo = repo;
            this.tradrepo = tradrepo;
        }
        public IViewComponentResult Invoke(Int64 traderFarmerID)
        {
            var rec = this.tradrepo.GetById(traderFarmerID);
            return View(rec);
        }

    }
}
