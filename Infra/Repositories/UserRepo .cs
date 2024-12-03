using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class UserRepo : IUserRepo
    {
        Context cntx;
        public UserRepo(Context cntx)
        {
            this.cntx = cntx;
        }

        public RepoResultVM Register(UserVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                User urec = new User();
                urec.Address = rec.Address;
                urec.FirstName = rec.FirstName;
                urec.LastName = rec.LastName;
                urec.Gender = rec.Gender;
                urec.CityID = rec.CityID;
                urec.EmailId = rec.EmailId;
                urec.Password = rec.Password;
                urec.PinCode = rec.PinCode;
                urec.Occupation = rec.Occupation;
                this.cntx.Users.Add(urec);
                this.cntx.SaveChanges();
                res.IsSuccess = true;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.Message;
            }
            return res;
        }
        public RepoResultVM ChangePassword(ChangePasswodVM rec, long userid)
        {
            var srec = this.cntx.Users.Find(userid);

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


        public RepoResultVM EditProfile(UserProfileVM rec, long userid)
        {
            var srec = this.cntx.Users.Find(userid);
            RepoResultVM res = new RepoResultVM();
            try
            {
                srec.Address = rec.Address;
                srec.FirstName = rec.FirstName;
                srec.LastName = rec.LastName;
                srec.Gender = rec.Gender;
                srec.CityID = rec.CityID;
                srec.EmailId = rec.EmailId;
                srec.Password = rec.Password;
                srec.PinCode = rec.PinCode;
                srec.Occupation = rec.Occupation;
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


        public UserProfileVM GetUserProfile(long useridid)
        {
            var rec = from t in this.cntx.Users
                      where t.UserID == useridid
                      select new UserProfileVM
                      {
                          Address = t.Address,
                          FirstName = t.FirstName,
                          LastName = t.LastName,
                          EmailId = t.EmailId,
                          CityID = t.CityID,
                          Occupation=t.Occupation,
                          PinCode=t.PinCode
                      };

            return rec.FirstOrDefault();
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var userrec = this.cntx.Users.SingleOrDefault(p => p.EmailId == rec.EmailID && p.Password == rec.Password);

            if (userrec != null)
            {
                res.IsLoggedIn = true;
                res.LoggedInName = userrec.FullName;
                res.LoggedInId = userrec.UserID;
            }
            else
            {
                res.IsLoggedIn = false;
            }

            return res;
        }

       
    }
}
