using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class OrderRepo :IOrderRepo
    {
        Context cntx;
        public OrderRepo(Context cntx)
        {
            this.cntx = cntx;
        }

        public List<UserOrder> AllDispatchedOrders()
        {
            var res = from t in this.cntx.UserOrders
                      join t1 in this.cntx.OrderDispatches
                      on t.UserOrderID equals t1.UserOrderID
                      select t;
            return res.ToList();
        }

        public List<UserOrder> AllDispatchedOrders(long userid)
        {
            var res = from t in this.cntx.UserOrders
                      join t1 in this.cntx.OrderDispatches
                      on t.UserOrderID equals t1.UserOrderID
                      where t.UserID == userid
                      select t;
            return res.ToList();
        }

        public List<UserOrder> AllNewOrders()
        {
            var res = from t in this.cntx.UserOrders
                      where !(
                        this.cntx.OrderDispatches.Any(p => p.UserOrderID == t.UserOrderID)
                      )
                      select t;

            return res.ToList();
        }

        public List<UserOrder> AllNewOrders(long userid)
        {
            var res = from t in this.cntx.UserOrders
                      where !(
                        this.cntx.OrderDispatches.Any(p => p.UserOrderID == t.UserOrderID)
                      ) && t.UserID == userid
                      select t;

            return res.ToList();
        }

        public RepoResultVM DispatchOrder(OrderDispatch rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cntx.OrderDispatches.Add(rec);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Order Dispatched!!!!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }


        public UserOrder GetOrderByID(long orderid)
        {
            return this.cntx.UserOrders.Find(orderid);
        }

    }
}
