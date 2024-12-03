using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class FarmerLoginVM

    {
        
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Contact No should be in 10 digits")]
        public string MobileNo { get; set; }
    }
}
