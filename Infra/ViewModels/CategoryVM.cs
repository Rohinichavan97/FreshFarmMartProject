using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class CategoryVM
    {
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string PurchaseLimitInQty { get; set; }
    }
}
