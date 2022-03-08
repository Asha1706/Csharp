using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class Class1
    {
        static void Main()
        {
            Queue q = new Queue(); q.Enqueue(50); q.Enqueue("World"); q.Enqueue(false);
            q.Enqueue('A'); q.Enqueue(DateTime.Now.ToShortDateString()); q.Enqueue(45.73);
            foreach (object obj in q) { Console.Write(obj + " "); }
            Console.WriteLine();
            Console.WriteLine(q.Dequeue());
            foreach (object obj in q) { Console.Write(obj + " "); }
            Console.ReadLine();
        }
    }
}
