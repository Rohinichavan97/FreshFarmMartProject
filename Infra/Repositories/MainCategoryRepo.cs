using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class MainCategoryRepo : GenericRepo<MainCategory>, IMainCategoryRepo
    {
        Context cc;
        public MainCategoryRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
