using Core;
using Core.Enum;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface ICartRepo : IGenericRepo<Cart>
    {
        RepoResultVM AddToCart(Int64 userid, Int64 productid);
        List<CartProductDiscountVM> GetCart(Int64 userid);
        int GetCartCount(Int64 userid);
   
        RepoResultVM Delete(Int64 cartid);
        RepoResultVM PlaceOder(Int64 userid, PaymentModeEnum pmode);
    }
}
