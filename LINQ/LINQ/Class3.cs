using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    
     public class Class3
    {
        static void Main()
        {
            Customer c1 = new Customer { Id = 101, Name = "Scott", City = "Delhi", Balance = 15000.00, Status = true };
            Customer c2 = new Customer { Id = 102, Name = "Dave", City = "Mumbai", Balance = 10000.00, Status = true };
            Customer c3 = new Customer { Id = 103, Name = "Sunitha", City = "Chennai", Balance = 15600.00, Status = false };
            Customer c4 = new Customer { Id = 104, Name = "David", City = "Delhi", Balance = 22000.00, Status = true };
            Customer c5 = new Customer { Id = 105, Name = "John", City = "Kolkata", Balance = 34000.00, Status = true };
            Customer c6 = new Customer { Id = 106, Name = "Jane", City = "Hyderabad", Balance = 19000.00, Status = true };
            Customer c7 = new Customer { Id = 107, Name = "Kavitha", City = "Mumbai", Balance = 16500.00, Status = true };
            Customer c8 = new Customer { Id = 108, Name = "Steve", City = "Bengaluru", Balance = 34600.00, Status = false };
            Customer c9 = new Customer { Id = 109, Name = "Sophia", City = "Chennai", Balance = 6300.00, Status = true };
            Customer c10 = new Customer { Id = 110, Name = "Rehman", City = "Delhi", Balance = 9500.00, Status = true };
            Customer c11 = new Customer { Id = 111, Name = "Raj", City = "Hyderabad", Balance = 9800.00, Status = false };
            Customer c12 = new Customer { Id = 112, Name = "Rupa", City = "Kolkata", Balance = 13200.00, Status = true };
            Customer c13 = new Customer { Id = 113, Name = "Ram", City = "Bengaluru", Balance = 47700.00, Status = true };
            Customer c14 = new Customer { Id = 114, Name = "Joe", City = "Hyderabad", Balance = 26900.00, Status = false };
            Customer c15 = new Customer { Id = 115, Name = "Peter", City = "Delhi", Balance = 17400.00, Status = true };
            List<Customer> Customers = new List<Customer>() { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15 };
            //var Coll = from C in Customers select C;

            //var Coll = from C in Customers select new { C.Id, C.Name, C.Balance };
            //var Coll = from C in Customers orderby C.Name select C;
            //var Coll = from C in Customers orderby C.Balance descending select C;
           // var Coll = from C in Customers where C.Balance > 15000 select C;
            //var Coll = from C in Customers where C.City == "Hyderabad" select C;
            //var Coll = from C in Customers where C.City == "Delhi" && C.Balance > 10000 select C;
            //var Coll = from C in Customers where C.City == "Mumbai" || C.Balance > 25000 select C;
            //var Coll = from C in Customers group C by C.City into G select new { City = G.Key, Count = G.Count() };
            //var Coll = from C in Customers group C by C.City into G where G.Count() > 2 select new { City = G.Key,  Count = G.Count()};

            //var Coll = from C in Customers group C by C.City into G select new { City = G.Key,MaxBalance = G.Max(C => C.Balance)}; 


            //var Coll = from C in Customers group C by C.City into G select new { City = G.Key, MinBalance = G.Min(C => C.Balance) };


            //var Coll = from C in Customers group C by C.City into G select new { City = G.Key,  TotalBalance = G.Sum(C => C.Balance) };

            var Coll = from C in Customers
           group C by C.City into G
           where G.Sum(C => C.Balance) > 30000
           select new { City = G.Key, TotalBalance = G.Sum(C => C.Balance) };
           foreach (var customer in Coll)
           Console.WriteLine(Customers);
            Console.ReadLine();
         }
     }
}
 
  

