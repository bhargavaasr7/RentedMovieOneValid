using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentedMovieOneValid.Models;

namespace RentedMovieOneValid.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == Id);
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
    }
}