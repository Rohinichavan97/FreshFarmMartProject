using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserOrderTbl")]
    public class UserOrder
    {
        [Key]
        public Int64 UserOrderID { get; set; }

        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime OrderDate { get; set; } 
        public bool IsPaid { get; set; }

 

        public virtual List<UserOrderDet> UserOrderDets { get; set; }
        public virtual List<UserOrderPayment> UserOrderPayments { get; set; }
        public virtual List<UserOrderComplaint> UserOrderComplaints { get; set; }
        public virtual List<OrderDispatch> OrderDispatches { get; set; }


        public UserOrder()
        {
            this.UserOrderDets = new List<UserOrderDet>();
            this.UserOrderPayments = new List<UserOrderPayment>();
        }
    }
}

