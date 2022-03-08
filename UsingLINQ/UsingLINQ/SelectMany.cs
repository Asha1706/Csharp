using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    internal class Employee
    {
        public int ID;
        public string Name;
        public List<string> Skills;

        public static List<Employee> GetEmpDetails()
        {
            return new List<Employee>()
            {
            new Employee(){ID = 101, Name = "Amit",  Skills = new List<string>() { "C", "C++", "SQL"} },
            new Employee(){ID = 102, Name = "Sumit",  Skills = new List<string>() { "C#", "VB.NET" }},
            new Employee(){ID = 103, Name = "Patriq", Skills = new List<string>() { "JAVA","JSP","AZURE"} },
            new Employee(){ID = 104, Name = "Arun",   Skills = new List<string>() { "ADO.NET", "OLEDB", "ODBC" } }
            };
        }

        static void Main(string[] args)
        {
            List<string> skill_list = Employee.GetEmpDetails().SelectMany(emp => emp.Skills).ToList();

            foreach (string skill in skill_list)
            {
                Console.Write(skill + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
