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
    public class CartRepo : GenericRepo<Cart>, ICartRepo
    {
        Context cc;
        public CartRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM AddToCart(long userid, long productid)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                //find product
                var product = this.cc.Products.Find(productid);

                //check weather the product is in cart. 
                var cartrec = this.cc.Cart.SingleOrDefault(p => p.UserID == userid && p.ProductID == productid);

                if (cartrec != null)
                {
                    cartrec.Qty++;
                    this.cc.SaveChanges();
                }
                else
                {
                    Cart crec = new Cart();
                    crec.ProductID = productid;
                    crec.Qty = 1;
                    crec.Price = product.Price;
                    crec.UserID = userid;
                    this.cc.Cart.Add(crec);
                    this.cc.SaveChanges();
                }
                res.IsSuccess = true;
                res.Message = "Added To Cart!";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public RepoResultVM Delete(long cartid)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var rec = this.cc.Cart.Find(cartid);
                this.cc.Cart.Remove(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Deleted From Cart";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }

        public List<CartProductDiscountVM> GetCart(long userid)
        {
            var res = this.cc.Cart
                    .Where(p => p.UserID == userid)
                    .Select(c => new CartProductDiscountVM
                    {
                        ProductID = c.ProductID,
                        CartID = c.CartID,
                        Qty = c.Qty,
                        Price = c.Price,
                        MainPhotoPath = c.Product.MainPhotoPath,
                        ProductDesc = c.Product.ProductDesc,
                        DiscountName = c.Product.ProductDiscounts.FirstOrDefault().DiscountName,
                        DiscountAmount = c.Product.ProductDiscounts.FirstOrDefault().DiscountAmount,
                        IsPercentile = c.Product.ProductDiscounts.FirstOrDefault().IsPercentile
                    });

            return res.ToList();
        }

        public int GetCartCount(long userid)
        {
            return this.cc.Cart.Count(p => p.UserID == userid);
        }

        public RepoResultVM PlaceOder(long userid, PaymentModeEnum pmode)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var cartrec = this.cc.Cart
                    .Where(p => p.UserID == userid)
                    .Select(c => new CartProductDiscountVM
                    {
                        ProductID = c.ProductID,
                        CartID = c.CartID,
                        Qty = c.Qty,
                        Price = c.Price,
                        MainPhotoPath = c.Product.MainPhotoPath,
                        ProductDesc = c.Product.ProductDesc,
                        DiscountName = c.Product.ProductDiscounts.FirstOrDefault().DiscountName,
                        DiscountAmount = c.Product.ProductDiscounts.FirstOrDefault().DiscountAmount,
                        IsPercentile = c.Product.ProductDiscounts.FirstOrDefault().IsPercentile
                    }).ToList();

                decimal amount = 0;
                foreach (var item in cartrec)
                {
                    decimal discountAmount = item.DiscountAmount;
                    amount += item.Qty * (item.Price - discountAmount);
                }

                UserOrder ord = new UserOrder();
                ord.OrderDate = DateTime.Now;
                ord.UserID = userid;
                if (pmode == PaymentModeEnum.Cash)
                    ord.IsPaid = false;
                else
                    ord.IsPaid = true;

                foreach (var temp in cartrec)
                {
                    UserOrderDet orderdet = new UserOrderDet();
                    orderdet.ProductID = temp.ProductID;
                    orderdet.Price = temp.Price;
                    orderdet.Qty = temp.Qty;
                    orderdet.DiscountName = temp.DiscountName;
                    orderdet.DiscountApplied = temp.DiscountAmount;
                    orderdet.IsPercentile = temp.IsPercentile;
                    orderdet.ActualDiscountAmount = temp.Qty * temp.DiscountAmount;
                    ord.UserOrderDets.Add(orderdet);
                }

                UserOrderPayment ordpayrec = new UserOrderPayment();

                ordpayrec.PaymentDate = DateTime.Now;
                ordpayrec.Amount = amount;
                ordpayrec.PaymentMode = pmode;
                ord.UserOrderPayments.Add(ordpayrec);

                this.cc.UserOrders.Add(ord);

                this.cc.SaveChanges();

                var newcartrec = this.cc.Cart.Where(p => p.UserID == userid);

                foreach (var temp in newcartrec)
                {
                    this.cc.Cart.Remove(temp);
                }
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Order Placed With Amount:" + amount + " Successfully!!!";

            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = "Failed to Palce Order:=> " + ex.Message;
            }

            return res;
        }
    }
}
