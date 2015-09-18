using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using PTTest.Models;

namespace PTTest.Controllers
{
    public class PTCustomerController : Controller
    {
        // GET: PTCustomer
        public ActionResult Index()
        {
            
            //Check custom interfaces

            return View();
        }
    }
}