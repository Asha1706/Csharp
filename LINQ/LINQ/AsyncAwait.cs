using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class AsyncAwait
    {
        static async void Test()
        {
            Console.WriteLine("Started reading values from DB.....");
            await Task.Delay(10000);
            Console.WriteLine("Completed reading values from DB.....");
        }
        static void Main()
        {
            Test();
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.ReadLine();
        }
    }
}
