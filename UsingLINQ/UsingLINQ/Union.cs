using System;
using System.Linq;
using System.Collections.Generic;
namespace UsingLINQ
{
    class Union
    {
        static void Main(string[] args)
        {
            List<int> List1 = new List<int>() { 10, 20, 30, 40, 50 };
            List<int> List2 = new List<int>() { 10, 40, 60, 80, 90 };

            var result = List1.Union(List2);

            foreach (var value in result)
            {
                Console.WriteLine(value + " ");
            }
        }
    }
}