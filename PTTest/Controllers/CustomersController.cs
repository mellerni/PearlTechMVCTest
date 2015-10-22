using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using PearlTech.DAL;
using PearlTech.Framework.Models;

namespace PTTest.Controllers
{
    public class CustomersController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Customers
        public ActionResult Index(Customer searchCustomer = null)
        {
            var customers = CustomerSearch(searchCustomer);

            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,CustomerId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(customer);
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable<Customer> CustomerSearch(Customer searchCustomer)
        {
            IQueryable<Customer> customers;
            if (searchCustomer == null)
            {
                customers = from c in _db.Customers
                            select c;

            }
            else if (searchCustomer.CustomerNumber != 0)
            {
                customers = from c in _db.Customers
                            where c.CustomerNumber.Equals(searchCustomer.CustomerNumber)
                            select c;
            }
            else if (searchCustomer.FirstName != null && searchCustomer.LastName != null)
            {
                customers = from c in _db.Customers
                            where c.LastName.Contains(searchCustomer.LastName) &&
                                  c.FirstName.Contains(searchCustomer.FirstName)
                            select c;
            }
            else if (searchCustomer.FirstName != null && searchCustomer.LastName == null)
            {
                customers = from c in _db.Customers
                            where c.FirstName.Contains(searchCustomer.FirstName)
                            select c;
            }
            else if (searchCustomer.FirstName == null && searchCustomer.LastName != null)
            {
                customers = from c in _db.Customers
                            where c.LastName.Contains(searchCustomer.LastName)
                            select c;
            }
            else
            {
                customers = from c in _db.Customers
                            select c;
            }
            return customers.AsEnumerable();
        }
    }
}
