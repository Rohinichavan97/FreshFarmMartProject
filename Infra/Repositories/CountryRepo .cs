using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class CountryRepo: GenericRepo<Country>, ICountryRepo
    {
        Context cc;
        public CountryRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public IEnumerable<Country> GetAll()
        {
            return cc.Countries.ToList();
        }
    }
}
