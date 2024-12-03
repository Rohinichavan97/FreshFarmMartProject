using Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.ViewModels
{
    public class PaymentModeVM
    {
        public PaymentModeEnum PMode { get; set; }
        public string CardNo { get; set; }
        public string CCV { get; set; }
        public string ExpiryDate { get; set; }
    }
}
