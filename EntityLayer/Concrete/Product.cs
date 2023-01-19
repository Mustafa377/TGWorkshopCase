using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; } // primary key
        [StringLength(50)]
        public string ProductName { get; set; } // product name
        [StringLength(1000)]
        public string ProductDescription { get; set; } // product description

        public decimal ProductPrice { get; set; } // product price
        public short ProductStock { get; set; } // product stock
        public bool ProductStatus { get; set; } // true = active, false = passive
        public int CategoryID { get; set; } // foreign key
        public virtual Category Category { get; set; } // navigation property
    }
}
