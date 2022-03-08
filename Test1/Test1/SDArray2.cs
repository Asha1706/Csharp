using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class SDArray2
    {
        static void Main()
        {
            Console.Clear();
            int[] arr = { 54, 79, 59, 8, 42, 22, 93, 3, 73, 38, 67, 48, 18, 61, 32, 86, 15, 27, 81, 96 };
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            Array.Sort(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            Array.Reverse(arr);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
            int[] brr = new int[10];
            Array.Copy(arr, brr, 7);
            foreach (int i in brr)
                Console.Write(i + " ");
            Console.WriteLine();




        }
    }
}

