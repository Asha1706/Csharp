using System;
class MethodOverLoading
{
    public void Add(int a, int b)
    {
       int result = a + b;
        Console.WriteLine("result of two integers is:" + result);
    }
    public void Add(int a, int b,int c)
    {
        int result =a + b + c;
        Console.WriteLine("result of 3 integers is:" + result); 
    }
    public void Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine("result of two double values is:" + result);
    }
    public void Add(double a, double b, double c)
    {
        double result = a + b + c;
        Console.WriteLine("result of 3 double values is:" + result);
    }
    
}
   