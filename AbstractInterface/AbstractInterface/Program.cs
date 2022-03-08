using System;


abstract class Abs
{
    public abstract void Add(int x, int y);
    public abstract void Method1();
}

interface Inf
{
    public  void Sub(int x, int y);
    void Method2();
}

class Sample : Abs, Inf
{
    public override void Add(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public override void Method1()
    {

        Console.WriteLine("Method1() called");
    }
    public void Sub(int x, int y)
    {
        Console.WriteLine(x-y );
    }
    public void Method2()
    {
        Console.WriteLine("Method2() called");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Abs M1 = new Sample();
        Inf M2 = new Sample();

        M1 = new Sample();
        M2 = new Sample();

        M1.Method1();
        M2.Method2();
        M1.Add(23, 54);
        M2.Sub(44, 06);
    }
}