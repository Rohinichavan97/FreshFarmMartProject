using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class MenuVC: ViewComponent
    {
        IMainCategoryRepo mainCategoryRepo;
        ISearchProductRepo repo;
        public MenuVC(IMainCategoryRepo mainCategoryRepo, ISearchProductRepo repo)
        {
            this.mainCategoryRepo = mainCategoryRepo;
            this.repo = repo;
        }
        public IViewComponentResult Invoke()
        {
            var res = this.repo.GetAll();
            return View(res);
        }
    }
}
