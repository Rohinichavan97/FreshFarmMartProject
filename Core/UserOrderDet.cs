using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserOrderDetTbl")]
    public class UserOrderDet
    {
        [Key]
        public Int64 UserOrderDetID { get; set; }
        [ForeignKey("UserOrder")]
        public Int64 UserOrderID { get; set;}
        public virtual UserOrder UserOrder { get; set; }

        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public virtual Product Product { get; set; }  //FK not giving
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string DiscountName { get; set; }
        public decimal DiscountApplied { get; set; }
        public bool IsPercentile { get; set; }
        public decimal ActualDiscountAmount { get; set; }

    }
}
