using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CategoryRepo : GenericRepo<Category>, ICategoryRepo
    {
        Context cc;
        public CategoryRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<CategoryVM> GetCategoryByMainCategoryID(long MainCategoryID)
        {
            var res = from t in this.cc.Categories
                      where t.MainCategoryID == MainCategoryID
                      select new CategoryVM
                      {
                          CategoryID = t.CategoryID,
                          CategoryName = t.CategoryName,
                          PurchaseLimitInQty=t.PurchaseLimitInQty.ToString()
                      };
            return res.ToList();
        }
    }
}

