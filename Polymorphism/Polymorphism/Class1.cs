using System;


namespace Polymorphism
{
    internal class Class1
    {
        static void Main()
        {
            MethodOverLoading m = new MethodOverLoading();
            m.Add(1, 2); m.Add(2, 3, 12); m.Add(1.33, 4.55); m.Add(1.22, 4.56, 65.87);
            Console.ReadLine();
        }
    }
}
