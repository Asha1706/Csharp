using System;
using System.Collections.Generic;
using System.Linq;
class MyClass
{
    internal void Method1()
    {
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine("Method1 = "+i );
        }
    }
    internal void Method2()
    {
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine("Method2 ="+i );
        }
    }
}