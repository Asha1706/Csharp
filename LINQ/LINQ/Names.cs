using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Names
    {
        static void Main()
        {
            
            List<string> students = new List<string>{ "Asha", "Shiva","vinitha", "Bhanu", "Raj", "Dsk"};
            var coll = from s in students where s.Length == 5 select s;
            var result = students.OrderByDescending(n => n);
            Console.Write("Sorted list in Descending order:\n");
            foreach (string student in result)
            {
                Console.Write(student + " ");
            }
            Console.ReadLine();
        }
    }
}
