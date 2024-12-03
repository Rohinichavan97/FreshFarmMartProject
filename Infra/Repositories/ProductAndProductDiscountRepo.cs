using Core;
using Infra.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductAndProductDiscountRepo : IProductAndProductDiscountRepo
    {
        Context cntx;
        public ProductAndProductDiscountRepo(Context cntx)
        {
            this.cntx = cntx;
        }


        

        public void ProductDiscounts(ProductAndProductDiscountVM rec, Int64[] chk)
        {
            var P = new Product()
            {
                ProductID = rec.ProductID,
                ProductName=rec.ProductName,
                ProductDesc=rec.ProductDesc,
                CategoryID=rec.CategoryID,
                UnitID=rec.UnitID,
                Qty=rec.Qty,
                Price=rec.Price,
                MainPhotoPath=rec.MainPhotoPath,
                TraderFarmerID=rec.TraderFarmerID,


    };

            this.cntx.Products.Add(P);


            var req = new ProductDiscount()
            {
                ProductDiscountID=rec.ProductDiscountID,
                ProductID=rec.ProductID,
                DiscountName=rec.DiscountName,
                DiscountAmount=rec.DiscountAmount,
                IsPercentile=rec.IsPercentile
              
            };

            P.ProductDiscounts.Add(req);

            this.cntx.Products.Add(P);
            this.cntx.SaveChanges();
        }

        public void Update(ProductAndProductDiscountVM rec)
        {
            var P = new Product()
            {
                ProductID = rec.ProductID,
                ProductName = rec.ProductName,
                ProductDesc = rec.ProductDesc,
                CategoryID = rec.CategoryID,
                UnitID = rec.UnitID,
                Qty = rec.Qty,
                Price = rec.Price,
                MainPhotoPath = rec.MainPhotoPath,
                TraderFarmerID = rec.TraderFarmerID,

            };

            this.cntx.Products.Add(P);


            var req = new ProductDiscount()
            {
                ProductDiscountID = rec.ProductDiscountID,
                ProductID = rec.ProductID,
                DiscountName = rec.DiscountName,
                DiscountAmount = rec.DiscountAmount,
                IsPercentile = rec.IsPercentile

            };

            P.ProductDiscounts.Add(req);

            this.cntx.Products.Update(P);
            this.cntx.SaveChanges();
        }
    }

    
}
