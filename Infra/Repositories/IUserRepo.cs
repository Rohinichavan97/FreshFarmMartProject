using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IUserRepo
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswodVM rec, Int64 userid);
        RepoResultVM EditProfile(UserProfileVM rec, Int64 userid);
        UserProfileVM GetUserProfile(Int64 userid);
    
        RepoResultVM Register(UserVM rec);

    }
}
