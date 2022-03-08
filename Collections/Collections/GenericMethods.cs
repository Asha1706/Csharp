using System;
using System.Collections.Generic;

namespace Collections
{
    class Math<T>
    {
        public void Add(T x, T y)
        {
            dynamic a = x; dynamic b = y; Console.WriteLine(a + b);
        }
        public void Sub(T x, T y)
        {
            dynamic a = x; dynamic b = y; Console.WriteLine(a - b);
        }
        public void Mul(T x, T y)
        {
            dynamic a = x; dynamic b = y; Console.WriteLine(a * b);
        }
        public void Div(T x, T y)
        {
            dynamic a = x; dynamic b = y; Console.WriteLine(a / b);
        }
    }
    class TestGenericClass
    {
        static void Main()
        {
            Math<int> pi = new Math<int>();
            pi.Add(100, 200); pi.Sub(234, 123); pi.Mul(12, 46); pi.Div(900, 45);
            Math<double> pd = new Math<double>();
            pd.Add(145.35, 12.5); pd.Sub(45.6, 23.4); pd.Mul(15.67, 3.4); pd.Div(168.2, 14.5);
            Console.ReadLine();

        }
    }
}
