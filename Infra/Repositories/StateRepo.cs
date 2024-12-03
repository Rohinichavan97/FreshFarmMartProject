using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class StateRepo: GenericRepo<State>, IStateRepo
    {
        Context cc;
        public StateRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<StateVM> GetStatesByCountryID(long CountryID)
        {
            var res = from t in this.cc.states
                      where t.CountryID == CountryID
                      select new StateVM
                      {
                          StateID = t.StateID,
                          StateName = t.StateName
                      };
            return res.ToList();
        }
    }
}
