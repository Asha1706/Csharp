using System;
class TypesDemo
{
    static int x; 
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Field x value is: " + x + " and it's type is: " + x.GetType());
        int y = 10; 
        Console.WriteLine("Variable y value is: " + y + " and it's type is: " + y.GetType());
        float f = 3.14f; 
        Console.WriteLine("Variable f value is: " + f + " and it's type is: " + f.GetType());
        double d = 3.14; 
        Console.WriteLine("Variable d value is: " + d + " and it's type is: " + d.GetType());
        decimal de = 3.14m; 
        Console.WriteLine("Variable de value is: " + de + " and it's type is: " + de.GetType());
        var s = "Hello";
        Console.WriteLine(s.GetType());
        Console.ReadLine();
    }
}