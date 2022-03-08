using System;
namespace Delegate
{ 
    public delegate string WishDelegate(string name);
    class Lambda 
    {
        static void Main()
        {
            wishDelegate wd = name => 
            {
                return "Hello Mr./Ms./Mrs. " + name + " have a nice day.";
            };
            Console.WriteLine(wd("Asha"));
            Console.WriteLine(wd("Pasha"));
            Console.WriteLine(wd("Mohammad"));
            
            Console.ReadLine();
        }
    }
}
