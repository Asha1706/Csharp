using System;

namespace Delegate
{

    internal class AnonymousMethod
    {
        static void Main()
        {
            wishDelegate wd = delegate (string name)
            {
                return "Hello Mr./Ms./Mrs. " + name + " have a nice day.";
            };
            CalculatorDelegate cd = delegate (int a, int b, int c)
            {
                Console.WriteLine(a * b * c);
            };
            Console.WriteLine(wd("Asha"));
            Console.WriteLine(wd("Pasha"));
            Console.WriteLine(wd("Mohammad"));
            cd(10, 20, 30); cd(40, 50, 60); cd(70, 80, 90);
            Console.ReadLine();
        }
    }
}
