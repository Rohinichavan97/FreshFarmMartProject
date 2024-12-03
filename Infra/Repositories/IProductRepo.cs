using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IProductRepo : IGenericRepo<Product>
    {
        List<Product> GetProductsByCategory(Int64 CategoryID);
        RepoResultVM ProductDiscounts(Product rec, Int64[] chk);
        Product GetProductDetails(long id);
        void AddPhoto(ProductPhoto photo);
        ProductPhoto GetPhotoById(Int64 productphotoId);
        void DeletePhoto(long productphotoId);
    }
}
