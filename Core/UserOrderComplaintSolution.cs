using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserOrderComplaintSolutionTbl")]
    public class UserOrderComplaintSolution
    {
        [Key]
        public Int64 UserOrderComplaintSolutionID { get; set; }
        [ForeignKey("UserOrderComplaint")]
        public Int64 UserOrderComplaintID { get; set; }
        public virtual UserOrderComplaint UserOrderComplaint { get; set; }
        public DateTime SolutionDate { get; set; }
        public string SolutionDesc { get; set; }
    }
}
