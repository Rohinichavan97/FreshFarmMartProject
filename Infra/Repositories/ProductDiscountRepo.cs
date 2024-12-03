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
    public class ProductDiscountRepo : GenericRepo<ProductDiscount>, IProductDiscountRepo
    {
        Context cc;
        public ProductDiscountRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public void ProductDiscounts(ProductDiscountVM rec)
        {
            var pc = new ProductDiscount()
            {
                ProductDiscountID = rec.ProductDiscountID,
                DiscountName=rec.DiscountName,
                DiscountAmount=rec.DiscountAmount,
                IsPercentile=rec.IsPercentile,
            };
            this.cc.ProductDiscounts.Add(pc);
            this.cc.SaveChanges();
           
        }





    }
}
