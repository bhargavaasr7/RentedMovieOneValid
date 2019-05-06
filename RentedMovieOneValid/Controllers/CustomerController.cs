using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using RentedMovieOneValid.Models;
using RentedMovieOneValid.View_Model;

namespace RentedMovieOneValid.Controllers
{
    public class CustomerController : Controller
    {
        private  ApplicationDbContext dbContext=null;
        public CustomerController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = dbContext.customers.Include(m =>m.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = dbContext.customers.Include(m=>m.MembershipType).SingleOrDefault(c => c.id == id);
            if (customer==null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { id = 1, name = "bhargava",DateOfBirth=Convert.ToDateTime("10-19-1996") },
                new Customer{id=2,name="surya", DateOfBirth=Convert.ToDateTime("01-01-1968")},
                new Customer{id=3,name="sankarapu",DateOfBirth=Convert.ToDateTime("10-09-1996")}
            };
            return customers;
        }
        public ActionResult Create()
        {
            CustomerMembershipViewModel viewModel = new CustomerMembershipViewModel();
            Customer customer = new Customer();
            var membershiptypes = dbContext.membershipTypes.ToList();
            viewModel.Customer = customer;
            viewModel.membershipTypes = membershiptypes;
            return View(viewModel);
        }
    }
}