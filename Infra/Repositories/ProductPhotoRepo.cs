using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProductPhotoRepo : GenericRepo<ProductPhoto>, IProductPhotoRepo
    {
        Context cc;
        public ProductPhotoRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
