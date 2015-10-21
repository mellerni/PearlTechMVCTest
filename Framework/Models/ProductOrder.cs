using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PearlTech.Framework.Models
{
    public class ProductOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Order Order { get; set;  }

    }
}