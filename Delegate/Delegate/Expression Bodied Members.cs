using System;


namespace Delegate
{
    internal class Expression_Bodied_Members
    {
        static void Main()
        {
            wishDelegate wd = name => "Hello Mr./Ms./Mrs. " + name + " have a nice day.";
            CalculatorDelegate cd = (a, b, c) => Console.WriteLine(a * b * c);
            Console.WriteLine(wd("Raju")); Console.WriteLine(wd("Naresh")); Console.WriteLine(wd("Praveen"));
            cd(10, 20, 30); cd(40, 50, 60); cd(70, 80, 90); Console.ReadLine(); Console.ReadLine();
        }
    }
}
