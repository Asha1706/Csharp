using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
       static void Main()
        {
            MyClass obj = new MyClass();
            ThreadStart tstart1 = new ThreadStart(obj.Method1);
            Thread thr1 = new Thread(tstart1);
            thr1.Start();


            ThreadStart tstart2 = new ThreadStart(obj.Method2);
            Thread thr2 = new Thread(tstart2);
            thr2.Start();
            Console.ReadLine();
        }
    }
}
