using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class FarmerVM
    {
      
        public string TradeName { get; set; }
       
       

        public Int64 CountryID { get; set; }
        public Int64 StateID { get; set; }
        public Int64 CityID { get; set; }

        public string Address { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public string ContactPerson{ get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
