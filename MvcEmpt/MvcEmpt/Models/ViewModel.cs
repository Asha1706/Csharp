using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEmpt.Models;


namespace MvcEmpt.Models
{
    public class ViewModel
    {
        public List<Book> Books { get; set; }
        public List<Customer> Customers { get; set; }

       
    }
}