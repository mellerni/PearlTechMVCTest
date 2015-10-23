﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PearlTech.Framework.Models
{
    public class Customer
    {
        public Customer()
        {
            var OrderList = new List<Order>();
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Customer Number")]
        public double CustomerNumber { get; set ; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
