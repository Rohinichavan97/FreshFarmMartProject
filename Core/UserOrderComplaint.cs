using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserOrderComplaintTbl")]
    public class UserOrderComplaint
    {
        [Key]
        public Int64 UserOrderComplaintID { get; set; }
        [ForeignKey("UserOrder")]
        public Int64 UserOrderID { get; set; }
        public virtual UserOrder UserOrder { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string ComplaintDesc { get; set; }
        public virtual List<UserOrderComplaintSolution> UserOrderComplaintSolutions { get; set; }
    }
}
