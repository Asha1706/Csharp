using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class TestFigures
    {
        static void Main()
        {
            Cone cone = new Cone(12.54, 67.34);
            Console.WriteLine("Area of Cone: " + cone.GetArea());
            Circle circ = new Circle(45.29);
            Console.WriteLine("Area of Circle: " + circ.GetArea());
            Triangle trin = new Triangle(67.32, 56.98);
            Console.WriteLine("Area of Triangle: " + trin.GetArea());
            Rectangle rect = new Rectangle(29.45, 32.78);
            Console.WriteLine("Area of Rectangle: " + rect.GetArea());
            Console.ReadLine();
        }
    }
}
