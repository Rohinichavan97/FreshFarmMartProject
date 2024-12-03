using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class LoginVM
    {
        [EmailAddress(ErrorMessage = "Invalid Email ID")]
        [Required]
        public string EmailID { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
     

    }
}
