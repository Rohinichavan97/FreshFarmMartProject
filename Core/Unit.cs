using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UnitTbl")]
    public class Unit
    {
        [Key]
        public Int64 UnitID { get; set; }
        public string UnitName { get; set; }
        public int QtyPerUnit { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
