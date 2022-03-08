using System;

namespace OOPSProject
{
    internal class TestMatrix
    {
        static void Main()
        {
           
            Matrix m1 = new Matrix(20, 19, 18, 17); Matrix m2 = new Matrix(15, 14, 13, 12);
            Matrix m3 = new Matrix(10, 9, 8, 7); Matrix m4 = new Matrix(5, 4, 3, 2);
           
            Matrix m5 = m1 + m2 + m3 + m4; Matrix m6 = m1 - m2 - m3 - m4;
            
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
            Console.WriteLine(m6);
           
            if (m1 == m2) { Console.WriteLine("Yes, m1 is equal to m2."); }
            else { Console.WriteLine("No, m1 is not equal to m2."); }
            
            if (m1 != m2) { Console.WriteLine("Yes, m1 is not equal to m2."); }
            else { Console.WriteLine("No, m1 is equal to m2."); }
            Console.ReadLine();
        }
    
    }
}
