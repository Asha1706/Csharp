using System;


namespace OOPSProject
{
    internal class TestProgram
    {
        public void CallMethods()
        {
            Program p = new Program();
            p.Test1(); p.Test2(9, 15);
            Console.WriteLine(p.Test3());
            Console.WriteLine(p.Test4("america"));
        }

        static void Main()
        {
            //Creating an un-named instance and calling the method
            new TestProgram().CallMethods();
            Console.ReadLine();
        }
    }
}
