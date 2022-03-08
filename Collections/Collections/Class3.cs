using System;

using System.Collections;

namespace Collections
{
    internal class Class3
    {
        static void Main()
        {
            Hashtable Emp = new Hashtable();
            Emp.Add("EmpId", 1005); Emp.Add("Name", "John"); Emp.Add("Job", "Manager");
            Emp.Add("HireDate", DateTime.Parse("01/21/2018"));
            Emp.Add("MgrId", 1001); Emp.Add("Salary", 25000.00); Emp.Add("Status", true);
            Emp.Add("Mobile", "98327 12742"); Emp.Add("Email", "john@gmail.com");
            Emp.Add("DeptId", 30); Emp.Add("Dname", "Sales"); Emp.Add("Location", "Mumbai");
            foreach (object key in Emp.Keys) { Console.WriteLine(key + ": " + Emp[key]); }
            Console.ReadLine();
        }
    }
}
