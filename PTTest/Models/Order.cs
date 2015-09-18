using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTTest.Models
{
    public class Order
    {
        private DateTime _orderDate;

        public Order()
        {
            var ProductList = new List<ProductOrder>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        [Display(Name = "Order Number")]
        public double OrderNumber { get; set; }

        [Display(Name = "Date Ordered")]
        public DateTime OrderDT { get; set; }

        [Display(Name = "Date Shipped")]
        public DateTime ShippedDT { get; set; }
    
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
