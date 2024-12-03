using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class LoginResultVM
    {
        public bool IsLoggedIn { get; set; }
        public string LoggedInName { get; set; }
        public Int64 LoggedInId { get; set; }
        public string LoggedEmailId { get; set; }
        public string LoggedMobileNo { get; set; }
    }
}
