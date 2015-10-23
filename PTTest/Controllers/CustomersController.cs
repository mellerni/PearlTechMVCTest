using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PearlTech.DAL.Interfaces;
using PearlTech.Framework.Models;

namespace PTTest.Controllers
{
    public class CustomersController : Controller
    {
        public CustomersController(IRepositoryBase<Customer> customerRepo)
        {
            _db = customerRepo;
        }

        private IRepositoryBase<Customer> _db;

        // GET: Customers
        public ActionResult Index(Customer searchCustomer = null)
        {
            var customers = CustomerSearch(searchCustomer);

            return View(customers);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,CustomerNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Insert(customer);
                _db.Commit();
                
                return RedirectToAction("Index");
            }
            else
            {
                return View(customer);
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Customer customer = _db.GetByID(id);
            
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,CustomerNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Update(customer);
                _db.Commit();
                
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public IEnumerable<Customer> CustomerSearch(Customer searchCustomer)
        {
            IEnumerable<Customer> customers;
            if (searchCustomer == null)
            {
                customers = _db.GetAll()
                    .Include(c => c.Orders
                        .Select(o => o.ProductOrder
                            .Select(p => p.Product)));

            }
            else if (searchCustomer.CustomerNumber != 0)
            {
                customers = _db.GetAll()
                    .Where(c => c.CustomerNumber == searchCustomer.CustomerNumber)
                    .Include(c => c.Orders
                        .Select(o => o.ProductOrder
                            .Select(p => p.Product)));
            }
            else if (searchCustomer.FirstName != null && searchCustomer.LastName != null)
            {
                customers = _db.GetAll()
                    .Where(c => c.FirstName.Contains(searchCustomer.FirstName) &&
                        c.LastName.Contains(searchCustomer.LastName))
                    .Include(c => c.Orders
                        .Select(o => o.ProductOrder
                            .Select(p => p.Product)));
            }
            else if (searchCustomer.FirstName != null && searchCustomer.LastName == null)
            {
                customers = _db.GetAll()
                    .Where(c => c.FirstName.Contains(searchCustomer.FirstName))
                    .Include(c => c.Orders
                        .Select(o => o.ProductOrder
                            .Select(p => p.Product)));
            }
            else if (searchCustomer.FirstName == null && searchCustomer.LastName != null)
            {
                customers = _db.GetAll()
                    .Where(c => c.LastName.Contains(searchCustomer.LastName))
                    .Include(c => c.Orders
                        .Select(o => o.ProductOrder
                            .Select(p => p.Product)));
            }
            else
            {
                customers = _db.GetAll()
                   .Include(c => c.Orders
                       .Select(o => o.ProductOrder
                           .Select(p => p.Product)));
            }

            return customers.ToList();
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
