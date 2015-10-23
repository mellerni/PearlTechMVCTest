using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using PearlTech.Framework.Models;

namespace PTTest.Models.ViewModels
{
    public class OrderProductList
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}