using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductReviewRepo : GenericRepo<ProductReview>, IProductReviewRepo
    {
        Context cc;
        public ProductReviewRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<ProductReview> GetProductReviewsByProductID(long productID)
        {
            var res = this.cc.ProductReviews.Where(p => p.ProductID == productID);
            return res.ToList();
        }
    }
}
