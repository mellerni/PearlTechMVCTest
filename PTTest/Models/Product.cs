using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTTest.Models
{
    public class Product
    {
        public Product()
        {
            var OrderList = new List<ProductOrder>();
        }

    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdcutID { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}