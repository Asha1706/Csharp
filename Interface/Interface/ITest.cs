using System;


namespace Interface
{
    internal interface ITest
    {
        void TestMethod();
    }
    class TestClass : ITest
    {
        void ITest.TestMethod()
        {
            Console.WriteLine("Expliciit Interface Implementation");
        }
    }
}
