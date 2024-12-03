using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IProductReviewRepo : IGenericRepo<ProductReview>
    {
        List<ProductReview> GetProductReviewsByProductID(Int64 productID);
    }
}
