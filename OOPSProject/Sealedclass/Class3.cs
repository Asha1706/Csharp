using System;

namespace Sealedclass
{
    class Class3 : Class2
    {
        public override void Show()
        {
            Console.WriteLine("class 3 constructor is called");
        }
        public void Test5()
        {
            Console.WriteLine("Method5");

        }
        public void Test6()
        {
            Console.WriteLine("Method6");
        }
        static void Main()
        {
            Class3 c = new Class3();
            c.Test1(); c.Test2(); c.Test3();
            c.Test4(); c.Test5(); c.Test6();
            Console.ReadLine();
        }
    }
}
 