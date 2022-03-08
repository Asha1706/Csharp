using System;

namespace Delegate
{
    class DelDemo1
    {
        public void AddNums(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name + ", good morning.";
        }
        static void Main()
        {
            DelDemo1 obj = new DelDemo1();
            CalculatorDelegate cd = obj.AddNums;

            cd(100, 50, 25); cd(123, 456, 789); cd(396, 224, 156);
            wishDelegate wd = DelDemo1.SayHello;

            Console.WriteLine(wd("Raju"));
            Console.WriteLine(wd("Naresh"));
            Console.WriteLine(wd("Praveen"));
            Console.ReadLine();
        }
    }
}

