using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("MainCategoryTbl")]
    public class MainCategory
    {
        [Key]
        public Int64 MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        
        public virtual List<Category> Categories { get; set; }
    }
}
