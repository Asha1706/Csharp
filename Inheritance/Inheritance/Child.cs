using System;
namespace Inheritance
{
    internal class Child:Parent
    {
        public void Test(int i)
        {
            Console.WriteLine("Child Class Test Method Is Called.");
        }
        public void PShow()
        {
            base.Show();
        }
        public void PDisplay()
        {
            base.Display();
        }
        static void Main()
        {
            Child c = new Child();
            c.Test();
            c.PShow();
            c.PDisplay();
            
        }
    }
}
