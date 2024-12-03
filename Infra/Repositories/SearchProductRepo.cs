using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class SearchProductRepo : GenericRepo<SearchProductVM>, ISearchProductRepo
    {
        Context cc;
        public SearchProductRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public IEnumerable<GetProductVM> GetProducts(SearchProductVM searchProductVM)
        {
            var data = (from prod in cc.Products
                        select new GetProductVM
                        {
                            ProductID=prod.ProductID,
                            CategoryID = prod.CategoryID,
                            ProductName= prod.ProductName,
                            ProductDesc = prod.ProductDesc,
                            CategoryName = prod.Category.CategoryName,
                            UnitName = prod.Unit.UnitName,
                            Qty=prod.Qty,
                            Price=prod.Price,
                            TradeName=prod.TraderFarmer.TradeName,
                            MainPhotoPath=prod.MainPhotoPath,

                            MainCategoryID = prod.Category.MainCategoryID,
                            CityID = prod.TraderFarmer.CityID,
                            CountryID = prod.TraderFarmer.City.State.CountryID,
                            StateID = prod.TraderFarmer.City.StateID,

                        }).ToList();


            if (searchProductVM == null)
                return data;


            if (searchProductVM.CategoryID > 0)
                data = data.Where(x => x.CategoryID == searchProductVM.CategoryID).ToList();

            if (searchProductVM.MainCategoryID > 0)
                data = data.Where(x => x.MainCategoryID == searchProductVM.MainCategoryID).ToList();

            if (searchProductVM.CountryID > 0)
                data = data.Where(x => x.CountryID == searchProductVM.CountryID).ToList();

            if (searchProductVM.StateID > 0)
                data = data.Where(x => x.StateID == searchProductVM.StateID).ToList();

            if (searchProductVM.CityID > 0)
                data = data.Where(x => x.CityID == searchProductVM.CityID).ToList();

                     

            return data;
        }
    }
}
