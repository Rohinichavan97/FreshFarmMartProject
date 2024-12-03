using Core;
using Infra.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductRep : GenericRepo<Product>, IProductRepo
    {
        Context cc;
        public ProductRep(Context cc) : base(cc)
        {
            this.cc = cc;
        }



        public List<Product> GetProductsByCategory(long CategoryID)
        {
            var res = from t in this.cc.Products
                      where t.CategoryID == CategoryID
                      select t;

            return res.ToList();
        }
        public Product GetProductDetails(long id)
        {
            var product = this.cc.Products
            .Include(p => p.ProductPhotos)
            .Include(p => p.ProductDiscounts)
            .Include(p => p.ProductReviews)
            .Include(p => p.TraderFarmer)
            .FirstOrDefault(p => p.ProductID == id);
            return product;
        }
        public RepoResultVM ProductDiscounts(Product rec, long[] chk)
        {

            RepoResultVM res = new RepoResultVM();
            try
            {
                foreach (var temp in chk)
                {
                    ProductDiscount pc = new ProductDiscount();
                    {
                        pc.ProductDiscountID = temp;
                    };
                    rec.ProductDiscounts.Add(pc);
                }
                this.cc.Products.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Product Added !!!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;
        }

        public ProductPhoto GetPhotoById(long productphotoId)
        {
            return cc.ProductPhotos.Find(productphotoId);
        }
        public void DeletePhoto(long productphotoId)
        {
            var photo = cc.ProductPhotos.Find(productphotoId);
            if (photo != null)
            {
                cc.ProductPhotos.Remove(photo);
                cc.SaveChanges();
            }
        }

        public void AddPhoto(ProductPhoto photo)
        {
            cc.ProductPhotos.Add(photo);
            cc.SaveChanges();
        }

        //public void DeleteProduct(long ProductID)
        //{
        //    var product = this.cc.Products
        //             .Include(p => p.ProductPhotos)
        //             .Include(p => p.ProductDiscounts)
        //             .Include(p => p.ProductReviews)
        //             .Include(p=>p.UserOrderDets)
        //             //.ThenInclude(pr => pr.Product)
        //             .FirstOrDefault(p => p.ProductID == ProductID);

        //    if (product == null)
        //        throw new Exception("Product not found.");


        //}

    }
}
