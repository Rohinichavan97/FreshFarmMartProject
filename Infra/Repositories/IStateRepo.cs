using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IStateRepo : IGenericRepo<State>
    {
         List<StateVM> GetStatesByCountryID(Int64 CountryID);
    }
}
