using System;

namespace Interface
{
    internal interface ClsMath
    {
        class ClsMath : IMath1, IMath2
        {
            public void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            public void Sub(int a, int b)
            {
                Console.WriteLine(a - b);
            }
            public void Mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            public void Div(int a, int b)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
