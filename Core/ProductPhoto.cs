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
    [Table("ProductPhotoTbl")]
    public class ProductPhoto
    {
        [Key]
        public Int64 ProudctPhotoID { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public virtual Product Product { get; set; }
        public string PhotoPath { get; set; }

        [NotMapped]
        public IFormFile PhotoFile { get; set; }
    }
}
