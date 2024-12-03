using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class CartProductDiscountVM
    {

        public Int64 ProductID { get; set; }
        public Int64 CartID { get; set; }
        public string MainPhotoPath { get; set; }
        public string ProductDesc { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsPercentile { get; set; }




    }

}
