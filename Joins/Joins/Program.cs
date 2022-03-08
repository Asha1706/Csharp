using System;
using System.Linq;
using System.Collections.Generic;

public class Employee
{
    public int ID;
    public int Salary;
    public int DEPT_ID;
    public string Name;
}

public class Department
{
    public int DEPT_ID;
    public string DEPT_Name;
}
public class JoinDemo
{
    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>()
        {
             new Employee {ID=101,   Name="Asha  "    , Salary=20000,DEPT_ID=101},
             new Employee {ID=102,   Name="Akash  "    , Salary=38000,DEPT_ID=102},
             new Employee {ID=103,   Name="Salman"    , Salary=35000,DEPT_ID=103},
             new Employee {ID=104,   Name="Ram   "    , Salary=20000,DEPT_ID=101},
             new Employee {ID=105,   Name="Shravani "    , Salary=50000,DEPT_ID=102},
             new Employee {ID=106,   Name="Dilip"    , Salary=50000,DEPT_ID=103},
        };

        List<Department> departments = new List<Department>()
        {
             new Department {DEPT_ID=101,   DEPT_Name="HR        "   },
             new Department {DEPT_ID=102,   DEPT_Name="ACCOUNTS  "   },
             new Department {DEPT_ID=103,   DEPT_Name="SALES     "   },
        };
        var ResultJoins = (from emp in employees
                           join dept in departments
                           on emp.DEPT_ID equals dept.DEPT_ID
                           select new
                           {
                               ID = emp.ID,
                               Name = emp.Name,
                               Salary = emp.Salary,
                               DeptName = dept.DEPT_Name
                           }).ToList();


        Console.WriteLine("Employee Details: ");
        foreach (var e in ResultJoins)
        {
            Console.WriteLine("\tID: " + e.ID + ", Name: " + e.Name +
                ", Salary: " + e.Salary + ", Department: " + e.DeptName);
        }
    }
}