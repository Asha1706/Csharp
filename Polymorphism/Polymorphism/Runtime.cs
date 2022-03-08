using System;


namespace Polymorphism
{
    internal class Runtime
    {
        static void Main(string[] args)
        {

            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
            Console.ReadLine();
        }
    }
}
