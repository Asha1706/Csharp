using System;

namespace Delegate
{
    internal class TestAnonymousTypes
    {
        static void Main()
        {
            var EmpType = new
            {
                Eno = 1005,
                Name = "Scott",
                Job = "Manager",
                Salary = 25000.00,
                Status = true,
                Dept = new { Did = 30, Dname = "Sales", Location = "Hyderabad" }
            };
            Console.WriteLine(EmpType); Console.ReadLine();
        }
    }
    class Printer
    {
        public static void Print(dynamic d)
        {
            Console.WriteLine("Employee No: " + d.Eno);
            Console.WriteLine("Employee Name: " + d.Name);
            Console.WriteLine("Employee Job: " + d.Job);
            Console.WriteLine("Employee Salary: " + d.Salary);
            Console.WriteLine("Employee Status: " + d.Status);
            Console.WriteLine("Department No: " + d.Dept.Did);
            Console.WriteLine("Department Name: " + d.Dept.Dname);
            Console.WriteLine("Department Location: " + d.Dept.Location);
        }
    }
}

