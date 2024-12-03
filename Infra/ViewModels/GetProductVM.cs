using Core;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class GetProductVM
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }

        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Int64 UnitID { get; set; }
        public string UnitName { get; set; }

        public int Qty { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string MainPhotoPath { get; set; }

        public Int64 TraderFarmerID { get; set; }
        public string TradeName { get; set; }
        public Int64 MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
  
       
        public Int64 CountryID { get; set; }
        public string CountryName { get; set; }
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
    }
}
