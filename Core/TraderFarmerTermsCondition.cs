using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FarmerTermsConditionTbl")]
    public class TraderFarmerTermsCondition
    {
        [Key]
        public Int64 TraderFarmerTermsConditionID { get; set; }
        public string TermsConditionTitle { get; set; }
        public string TermsConditionDesc { get; set; }
    }
}
