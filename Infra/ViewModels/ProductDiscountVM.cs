using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class ProductDiscountVM
    {
        public Int64 ProductDiscountID { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsPercentile { get; set; }  
    }
}
