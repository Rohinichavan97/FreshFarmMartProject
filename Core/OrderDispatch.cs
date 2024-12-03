using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("OrderDispatchTbl")]
    public class OrderDispatch
    {
        [Key]
        public Int64 OrderDispatchID { get; set; }
        [ForeignKey("UserOrder")]
        public Int64 UserOrderID { get; set; }
        [ForeignKey("DispatchAgency")]
        public Int64 DispatchAgencyID { get; set; }
        public string DocketNo { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ExpectedReachDate { get; set; }
        public virtual DispatchAgency DispatchAgency { get; set; }
        public virtual UserOrder UserOrder { get; set; }
    }
}
