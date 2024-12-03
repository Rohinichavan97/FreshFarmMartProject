using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Core.Enum;


namespace Core.Enum
{
    public enum PaymentModeEnum
    {
        Cash=1,
        DebitCard=2,
        CreditCard=3,
        Cheque =4,
        UPI=5
    }
}
