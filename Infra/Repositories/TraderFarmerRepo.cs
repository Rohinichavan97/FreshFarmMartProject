using Core;
using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class TraderFarmerRepo: GenericRepo<TraderFarmer>, ITraderFarmerRepo
    {
        Context cntx;
        public TraderFarmerRepo(Context cntx):base(cntx)
        {
            this.cntx = cntx;
        }

        public RepoResultVM ChangePassword(ChangePasswodVM rec, long TraderFarmerID)
        {
            var srec = this.cntx.TraderFarmers.Find(TraderFarmerID);

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

       
        public RepoResultVM EditProfile(AdminProfileVM rec, long TraderFarmerID)
        {
            var srec = this.cntx.TraderFarmers.Find(TraderFarmerID);
            RepoResultVM res = new RepoResultVM();
            try
            {
               // srec.TradeName = rec.TradeName;
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

        public AdminProfileVM GetFarmerProfile(long TraderFarmerID)
        {
            var rec = from t in this.cntx.TraderFarmers
                      where t.TraderFarmerID == TraderFarmerID
                      select new AdminProfileVM
                      {
                          TradeName = t.TradeName,
                          Address = t.Address,
                          EmailID = t.EmailID,
                          ContactPerson = t.ContactPerson,
                          MobileNo = t.MobileNo,

                      };

            return rec.FirstOrDefault();
        }

        public LoginResultVM Login(FarmerLoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var carec = this.cntx.TraderFarmers.SingleOrDefault(p => p.MobileNo == rec.MobileNo && p.Password == rec.Password);

            if (carec != null)
            {
                res.IsLoggedIn = true;
                res.LoggedInName = carec.TradeName;
                res.LoggedInId = carec.TraderFarmerID;
            }
            else
            {
                res.IsLoggedIn = false;
            }

            return res;
        }

        public RepoResultVM Register(FarmerVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                TraderFarmer Frec = new TraderFarmer();
                Frec.Address = rec.Address;
                Frec.TradeName = rec.TradeName;
                Frec.EmailID = rec.Email;

                Frec.CityID = rec.CityID;
                Frec.MobileNo = rec.MobileNo;
                Frec.Password = rec.Password;
                Frec.PinCode = rec.PinCode;
                Frec.ContactPerson = rec.ContactPerson;
                Frec.RegistrationDate = rec.RegistrationDate;
                Frec.ActiveFlag = rec.ActiveFlag;


                this.cntx.TraderFarmers.Add(Frec);
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
    }
    
}
