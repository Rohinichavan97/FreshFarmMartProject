using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("AdminTbl")]
    public class Admin
    {
        public Int64 AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {

            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string ContactPerson { get; set; }
        public string Password { get; set; }


    }
}
