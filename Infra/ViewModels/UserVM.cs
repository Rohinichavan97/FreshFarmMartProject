using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class UserVM
    {
        // public Int64 UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }

        public GenderEnum Gender { get; set; }
        public Int64 CityID { get; set; }

        public string Address { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string PinCode { get; set; }
        public string Occupation { get; set; }
    }
}
