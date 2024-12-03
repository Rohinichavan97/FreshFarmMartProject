using Core;
using Core.Enum;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface IWishListRepo : IGenericRepo<WishList>
    {
        List<WishList> GetWisthListByUserID(Int64 userid);
        bool Exists(Int64 userid, Int64 pid);
        RepoResultVM AddToWisthList(Int64 userid, Int64 pid);
    }
}
