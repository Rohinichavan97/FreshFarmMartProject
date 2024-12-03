using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class AdminRepo: IAdminRepo
    {
        Context cntx;
        public AdminRepo(Context cntx)
        {
            this.cntx = cntx;
        }

        public RepoResultVM ChangePassword(ChangePasswodVM rec, long AdminId)
        {
            var srec = this.cntx.Admins.Find(AdminId);

            RepoResultVM res = new RepoResultVM();
            if (srec.Password == rec.OldPassword)
            {
                srec.Password = rec.NewPassword;
                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Password Changed!";
            }
            else
            {
                res.IsSuccess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;
        }


        public RepoResultVM EditProfile(AdminProfileVM rec, long AdminId)
        {
            var srec = this.cntx.Admins.Find(AdminId);
            RepoResultVM res = new RepoResultVM();
            try
            {
              // srec.FirstName = rec.FullName;
                srec.Address = rec.Address;
                srec.EmailID = rec.EmailID;
                srec.ContactPerson = rec.ContactPerson;
                srec.MobileNo = rec.MobileNo;

                this.cntx.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Profile Edited!";
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }

            return res;
        }

        public AdminProfileVM GetAdminProfile(long AdminId)
        {
            var rec = from t in this.cntx.Admins
                      where t.AdminId == AdminId
                      select new AdminProfileVM
                      {
                          FullName = t.FirstName + " " + t.LastName,
                          Address = t.Address,
                          EmailID = t.EmailID,
                          ContactPerson = t.ContactPerson,
                          MobileNo = t.MobileNo,
                      };

            return rec.FirstOrDefault();
        }

      

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var Adminrec = this.cntx.Admins.SingleOrDefault(p => p.EmailID == rec.EmailID && p.Password == rec.Password);

            if (Adminrec != null)
            {
                res.IsLoggedIn = true;
                res.LoggedInName = Adminrec.FullName;
                res.LoggedInId = Adminrec.AdminId;
            }
            else
            {
                res.IsLoggedIn = false;
            }

            return res;
        }

       
    }
}
