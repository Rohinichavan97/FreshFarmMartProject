using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class WishListRepo : GenericRepo<WishList>, IWishListRepo
    {
        Context cc;
        public WishListRepo(Context cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM AddToWisthList(long userid, long pid)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                WishList w = new WishList();
                w.AddedDate = DateTime.Now;
                w.ProductID = pid;
                //w.WishListDate = DateTime.Now;
                w.UserID = userid;
                this.cc.WishLists.Add(w);
                this.cc.SaveChanges();

                res.IsSuccess = true;
                res.Message = "Product Added To Wish List!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;

        }

        public bool Exists(long userid, long pid)
        {
            return this.cc.WishLists.Any(p => p.ProductID == pid && p.UserID == userid);
        }

        public List<WishList> GetWisthListByUserID(long userid)
        {
            return this.cc.WishLists.Where(p => p.UserID == userid).ToList();
        }
    }
}