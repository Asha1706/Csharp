using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Aggregate
    {
        static void Main(string[] args)
        {
            int[] values = { 10, 8, 2, 2, 7, 4 };
            int sum = 0;

            sum = values.Aggregate((val1, val2) => val1 + val2);

            Console.WriteLine("Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
