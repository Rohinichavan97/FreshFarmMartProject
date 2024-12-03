using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class DispatchAgencyRepo : GenericRepo<DispatchAgency>, IDispatchAgencyRepo
    {
        Context cc;
        public DispatchAgencyRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

      
    }
}
