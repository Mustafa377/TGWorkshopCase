using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; } // primary key
        [StringLength(50)]
        public string CategoryName { get; set; } // category name
        [StringLength(50)]
        public string CategoryDescription { get; set; } // category description
        public bool CategoryStatus { get; set; } // true = active, false = passive

        public ICollection<Product> Products { get; set; } // navigation property

    }
}
