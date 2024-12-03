using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProductTbl")]
    public class Product
    {
        [Key]
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        [ForeignKey("Category")]
        public Int64 CategoryID { get; set; }
        public virtual Category Category { get; set; }
        [ForeignKey("Unit")]
        public Int64 UnitID { get; set; }
        public virtual Unit Unit { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public IFormFile PhotoFile { get; set; }
        public string MainPhotoPath { get; set; }
        [ForeignKey("TraderFarmer")]
        public Int64 TraderFarmerID { get; set; }
        public virtual TraderFarmer TraderFarmer { get; set; }

        public virtual List<ProductPhoto> ProductPhotos { get; set; }
        public virtual List<ProductDiscount> ProductDiscounts { get; set; }
        public virtual List<ProductReview> ProductReviews { get; set; }
        public virtual List<UserOrderDet> UserOrderDets { get; set; }
        public virtual List<Cart> Carts { get; set; }



        public Product()
        {
            this.ProductDiscounts = new List<ProductDiscount>();
        }


    }
}
