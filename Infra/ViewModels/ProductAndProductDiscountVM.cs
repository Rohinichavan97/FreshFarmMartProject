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
    public class ProductAndProductDiscountVM
    {
        public Int64 ProductDiscountID { get; set; }
        
        public string DiscountName { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsPercentile { get; set; }
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
       
        public Int64 CategoryID { get; set; }
        public Category Category { get; set; }

        public Int64 UnitID { get; set; }
        public Unit Unit { get; set; }
        
        public int Qty { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string MainPhotoPath { get; set; }

        public Int64 TraderFarmerID { get; set; }
        public string TradeName { get; set; }


    }
}
