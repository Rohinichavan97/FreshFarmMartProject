using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IAdminRepo
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswodVM rec, Int64 AdminId);
        RepoResultVM EditProfile(AdminProfileVM rec, Int64 AdminId);
        AdminProfileVM GetAdminProfile(Int64 AdminId);
       
        
    }
}
