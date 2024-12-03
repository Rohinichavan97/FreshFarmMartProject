using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProductReviewTbl")]
    public class ProductReview
    {
        [Key]
        public Int64 ProductReviewID { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
        public string ReviewDesc { get; set; }
        public RatingEnum Rating { get; set; }   
    }
}
