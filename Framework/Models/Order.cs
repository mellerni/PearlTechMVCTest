using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PearlTech.Framework.Models
{
    public class Order
    {
        private DateTime _orderDate;

        public Order()
        {
            var ProductList = new List<ProductOrder>();
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Order Number")]
        public double OrderNumber { get; set; }

        [Display(Name = "Date Ordered")]
        public DateTime OrderDT { get; set; }

        [Display(Name = "Date Shipped")]
        public DateTime ShippedDT { get; set; }
    
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
