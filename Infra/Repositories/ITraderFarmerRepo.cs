using Core;
using Infra.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface ITraderFarmerRepo: IGenericRepo<TraderFarmer>
    {
        LoginResultVM Login(FarmerLoginVM rec);
        RepoResultVM ChangePassword(ChangePasswodVM rec, Int64 AdminId);
        RepoResultVM EditProfile(AdminProfileVM rec, Int64 AdminId);
        AdminProfileVM GetFarmerProfile(Int64 TraderFarmerID);
        RepoResultVM Register(FarmerVM rec);

    }
}
