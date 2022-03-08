using System;
class Program
{
    static void Main()
    {
        int[] array = { 3, 2, 1, 5, 4 };
        Console.WriteLine("Array Elements are;");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Array.Sort(array);
        foreach (int i in array)
            Console.Write(i + " ");
        Console.WriteLine();
        Array.Reverse(array);
        foreach (int i in array)
            Console.Write(i + " ");
        Console.WriteLine();
        Console.WriteLine("{0} is the second largest no in the array", array[1]);
        Console.ReadLine();
    }
}