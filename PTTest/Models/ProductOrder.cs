using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTTest.Models
{
    public class ProductOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Order Order { get; set;  }

    }
}