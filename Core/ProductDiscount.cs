using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProductDiscountTbl")]
    public class ProductDiscount
    {
        [Key]
        public Int64 ProductDiscountID { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public virtual Product Product { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsPercentile { get; set; }
    }
}
