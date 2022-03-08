using System;


namespace OOPSProject
{
    internal class OverloadMethods
    {
        public void Show()
        {
            Console.WriteLine(1);
        }
        public void Show(int i)
        {
            Console.WriteLine(2);
        }
        public void Show(string s)
        {
            Console.WriteLine(3);
        }
        public void Show(int i, string s)
        {
            Console.WriteLine(4);
        }
        public void Show(string s, int i)
        {
            Console.WriteLine(5);
        }

        static void Main()
        {
            OverloadMethods obj = new OverloadMethods();
            obj.Show(); obj.Show(10); obj.Show("Hello"); obj.Show(10, "Hello"); obj.Show("Hello", 10);
            Console.ReadLine();
        }
    }
}
