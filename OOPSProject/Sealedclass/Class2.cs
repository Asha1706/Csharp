using System;


namespace Sealedclass
{
    
        class Class2 : Class1
        {
        public sealed override void Show()
        {
                Console.WriteLine("Class2 constructor is called.");
            }
            public void Test3()
            {
                Console.WriteLine("Method 3");
            }
            public void Test4()
            {
                Console.WriteLine("Method 4");
            }
         //   static void Main()
          // {
           //     Class2 c = new Class2();
            //    c.Test1(); c.Test2(); c.Test3(); c.Test4();
             //   Console.ReadLine();

           // }
        }
    
}
