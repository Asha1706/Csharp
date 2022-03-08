using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UsingLINQ
{



    class Emp
    {
        int id;
        int age;
        string name;
        string department;
        public override string ToString()
        {
            return id + " " + name + " " +
               age + " " + department;
        }


        static void Main(string[] args)
        {


            List<Emp> emp = new List<Emp>()
           {
           new Emp{ id = 101, name = "Saritha",
                      age = 22, department = "HR" },
           new Emp{ id = 102, name = "deepu",
                      age = 24, department = "Development" },
           new Emp{ id = 103, name = "manoj",
                      age = 30, department = "HR" },
           new Emp{ id = 104, name = "Sathwika",
                      age = 28, department = "Designing" },
           new Emp{ id = 105, name = "Sasthri",
                      age = 40, department = "Development" }
           };
            IEnumerable<Emp> S = emp.Where(x => x.name[0] == 'S');
            Console.WriteLine("ID  Name  Salary  Department");
            Console.WriteLine("++++++++++++++++++++++++++++");
            foreach (Emp e in S)
            {
                Console.WriteLine(e.ToString());
            }
            IEnumerable<Emp> result = from Emp in emp where Emp.name[0] == 'S' select Emp;
            Console.WriteLine("ID  Name  Salary  Department");
            Console.WriteLine("++++++++++++++++++++++++++++");
            foreach (Emp e in result)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("++++++++++++++++++++++++++++");
            IEnumerable<Emp> age = from Emp in emp where Emp.age >= 23 select Emp;
            foreach (Emp e in age)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
