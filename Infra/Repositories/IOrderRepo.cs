using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IOrderRepo
    {
        UserOrder GetOrderByID(Int64 orderid);
        List<UserOrder> AllNewOrders();
        List<UserOrder> AllDispatchedOrders();

        List<UserOrder> AllNewOrders(Int64 userid);
        List<UserOrder> AllDispatchedOrders(Int64 userid);

        RepoResultVM DispatchOrder(OrderDispatch rec);
    }
}
