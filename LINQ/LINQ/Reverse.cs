using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    internal class Reverse
    {
        static void Main()
        { 
            int[] arr = { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93,
                6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            int Count = 0, Index = 0;
            foreach (int i in arr) { if (i > 40) Count += 1; }
            int[] brr = new int[Count];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    brr[Index] = arr[i]; Index += 1;
                }
            }
             Array.Reverse(brr);
            Console.WriteLine(String.Join(" ", brr));
            Console.ReadLine();
        }
    }
}
