using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TraderFarmerTbl")]
    public class TraderFarmer
    {
        [Key]
        public Int64 TraderFarmerID { get; set; }
        public string TradeName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string PinCode { get; set; }

        [ForeignKey("City")]
        public Int64 CityID { get; set; }
        public virtual City City { get; set; }
        public string ContactPerson { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool ActiveFlag { get; set; }


        public virtual List<Product> Products { get; set; }
    }
}
