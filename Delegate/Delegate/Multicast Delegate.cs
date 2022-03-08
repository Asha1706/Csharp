using System;


namespace Delegate
{
    internal class DelDemo2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Add: " + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub: " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Mul: " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("Div: " + (x / y));
        }
        static void Main()
        {
            DelDemo2 obj = new DelDemo2();
            MathDelegate md = obj.Add;
            md += obj.Sub; md += obj.Mul; md += obj.Div;
            md(100, 50); Console.WriteLine();
            md(575, 25); Console.WriteLine();
            md -= obj.Mul;
            md(678, 28);
            Console.ReadLine();
        }

    }
}
