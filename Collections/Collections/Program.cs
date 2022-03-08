using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack s = new Stack(); 
        s.Push(10); s.Push("Hello");
        s.Push(DateTime.Now.ToShortDateString());
        s.Push(true); s.Push(67.8); s.Push('A');
        foreach (object obj in s){ Console.Write(obj + " "); }
        Console.WriteLine();
        Console.WriteLine(s.Pop());
        foreach (object obj in s) { Console.Write(obj + " "); }
        Console.WriteLine();
        Console.WriteLine(s.Peek());
        foreach (object obj in s) { Console.Write(obj + " "); }
        Console.WriteLine();
        Console.WriteLine(s.Count); s.Clear(); Console.WriteLine(s.Count);
        Console.ReadLine();
    }
}