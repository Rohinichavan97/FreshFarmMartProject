using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class TraderFarmerTermsConditionRepo : GenericRepo<TraderFarmerTermsCondition>, ITraderFarmerTermsConditionRepo
    {
        Context cc;
        public TraderFarmerTermsConditionRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
