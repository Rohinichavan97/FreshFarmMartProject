using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ComplaintRefundTbl")]
    public class ComplaintRefund
    {
        [Key]
        public Int64 ComplaintRefundID { get; set; }
        [ForeignKey("UserOrderComplaintSolution")]
        public Int64 UserOrderComplaintSolutionID { get; set; }
        public virtual UserOrderComplaintSolution UserOrderComplaintSolution { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime ReundDate { get; set; }
        public PaymentModeEnum PaymentMode { get; set; }    
    }
}
