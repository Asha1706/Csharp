using System;
class ExceptionDemo
{
    static void Main()
    {
        
        
            Console.Write("Enter 1st number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("The result of division is: " + z);
            Console.WriteLine("End of the Program.");
        
       
    }
}

