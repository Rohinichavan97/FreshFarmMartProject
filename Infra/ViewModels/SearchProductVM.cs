using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class SearchProductVM
    {
        public Int64 MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CityID { get; set; }
        public string CityName { get; set; }

        public IEnumerable<GetProductVM> ProductDataVM { get; set; }

        public List<CategoryVM> Categories { get; set; }
    }
}
