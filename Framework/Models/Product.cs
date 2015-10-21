using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PearlTech.Framework.Models
{
    public class Product
    {
        public Product()
        {
            var OrderList = new List<ProductOrder>();
        }

    
        [Key]
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}