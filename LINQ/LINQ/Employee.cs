using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ
{
    public class Employee
    {


        int emp_id;
        int emp_age;
        string emp_name;
        double emp_salary;


        public override string ToString()
        {
            return emp_id + " " + emp_name + " " + emp_age +" "+ emp_salary+" ";
        }
        static void Main(string[] args)
        {


            List<Employee> emp1 = new List<Employee>()
            {


                new Employee{ emp_id = 101, emp_name = "Asha", emp_age = 12, emp_salary=15000.00},
                new Employee{ emp_id = 102, emp_name = "deepu", emp_age = 15,emp_salary=10000.00},
                new Employee{ emp_id = 103, emp_name = "manoj", emp_age = 13,emp_salary=12000.00},
                new Employee{ emp_id = 104, emp_name = "Shravani", emp_age = 14,emp_salary=9000.00},
                new Employee{ emp_id = 105, emp_name = "sravan", emp_age = 15,emp_salary=20000.00},
                new Employee{ emp_id = 106, emp_name = "navya", emp_age = 12,emp_salary=10000.00},
                new Employee{ emp_id = 107, emp_name = "majnu", emp_age = 12,emp_salary=12500.00},
                new Employee{ emp_id = 108, emp_name = "vishnu", emp_age = 12,emp_salary=32500.00},
            };
            IEnumerable<Employee> Query =
            from employee in emp1 where employee.emp_id > 101 select employee;
            IEnumerable<Employee> sal =
            from employee in emp1 where employee.emp_salary > 15000.00 select employee;
            IEnumerable<Employee> between =
            from employee in emp1 where employee.emp_salary >=10000.00 && employee.emp_salary <=15000.00  select employee;
            var emp_salary = emp1.OrderByDescending(x => x.emp_salary).Select(x => x.emp_salary).Skip(2-1).Distinct().Take(2).FirstOrDefault();
            var result = emp1.OrderByDescending(x => x.emp_salary).Skip(1).First();


            Console.WriteLine("ID  Name  Age  Salary");
            Console.WriteLine("-------------------------------");
            foreach (Employee e in Query)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("-------------------------------");
            foreach (Employee e in sal)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("-------------------------------");
            foreach (Employee e in between)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("-------------------------------");
            foreach(var employee in emp1)
            {
                Console.WriteLine(result);
            }
            
                
            


        }
    }
}

