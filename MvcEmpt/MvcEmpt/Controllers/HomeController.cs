using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEmpt.Models;



namespace MvcEmpt.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            var Book = new List<Book>()
            {
                new Book {BookName = "Programming in C#"},
                new Book {BookName = "Programming in F#"},
                new Book {BookName = "Programming in VB.NET"}
            };

            var Customer = new List<Customer>()
            {
                new Customer {CustomerName = "Asha"},
                new Customer {CustomerName = "Shravani"},
            };
            var ViewModel = new ViewModel()
            {

                Customers = Customer,
                Books = Book
            };

            return View();
        }
    }
}