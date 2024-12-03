using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("DispatchAgencyTbl")]
    public class DispatchAgency
    {
        [Key]
        public Int64 DispatchAgencyID { get; set; }
        public string AgencyName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string ContactPerson { get; set; }
        public virtual List<OrderDispatch> OrderDispatches { get; set; }
    }
}