using Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
	public class CategorySideBarVC : ViewComponent
	{
		IMainCategoryRepo mainCategoryRepo;
		public CategorySideBarVC(IMainCategoryRepo mainCategoryRepo)
		{
			this.mainCategoryRepo = mainCategoryRepo;
		}
		public IViewComponentResult Invoke()
		{
			var res = this.mainCategoryRepo.GetAll();
			return View(res);
		}
	}
}
