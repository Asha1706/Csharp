using System;
namespace Interface
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius; this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
        }
    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
    public class Triangle : Figure
    {
        public Triangle(double Base, double Height)
        {
            this.Width = Base; this.Height = Height;
        }
        public override double GetArea()
        {
            return 0.5 * Width * Height;
        }
    }
    public class Rectangle : Figure
    {
        public Rectangle(double Length, double Breadth)
        {
            this.Width = Length; this.Height = Breadth;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
   
}
        