﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CategoryTbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryID { get; set; }
        public string CategoryName { get; set; }

        [ForeignKey("MainCategory")]
        public Int64 MainCategoryID { get; set; }
        public virtual MainCategory MainCategory { get; set; }

        public int PurchaseLimitInQty { get; set; }

        public virtual List<Product> Products { get; set; } 
    }
}
