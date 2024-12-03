﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class UnitRepo: GenericRepo<Unit>, IUnitRepo
    {
        Context cc;
        public UnitRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
