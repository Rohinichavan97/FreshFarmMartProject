using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("WishListTbl")]
    public class WishList
    {
        [Key]
        public Int64 WishListID { get; set; }
        public DateTime WishListDate { get; set; }
        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public virtual Product Product { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
