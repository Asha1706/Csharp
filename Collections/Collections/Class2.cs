using System;
using System.Collections;

namespace Collections
{
    internal class Class2
    {
        static void Main()
        {
            ArrayList Coll1 = new ArrayList(2);
            Console.WriteLine("Initial capacity of collection: " + Coll1.Capacity);
            Coll1.Add(10);
            Console.WriteLine("Capacity after adding 1st item: " + Coll1.Capacity);
            Coll1.Add(true);
            Coll1.Add(DateTime.Now.ToShortDateString()); Coll1.Add(true);
            Console.WriteLine("Capacity after adding 4th item: " + Coll1.Capacity);
            Coll1.Add(45.7);
            Console.WriteLine("Capacity after adding 5th item: " + Coll1.Capacity); 
            Coll1.Add("Hello");
            for (int i = 0; i < Coll1.Count; i++) { Console.Write(Coll1[i] + " "); }
            Console.WriteLine();
            
            foreach (object obj in Coll1) { Console.Write(obj + " "); }
            Console.WriteLine();
            Coll1.Insert(1, 'Z'); foreach (object obj in Coll1) { Console.Write(obj + " "); }
            Console.WriteLine("\n");
            ArrayList Coll2 = new ArrayList(Coll1);
            foreach (object obj in Coll2) { Console.Write(obj + " "); }
            Console.WriteLine();
            Console.WriteLine("Initial capacity of new collection: " + Coll2.Capacity);
            Coll2.Add(3.14f);
            Console.WriteLine("New capacity of new collection: " + Coll2.Capacity);
            Coll2.TrimToSize();
            Console.WriteLine("Capacity of new collection after calling Trim: " + Coll2.Capacity);
            Console.ReadLine();
        }
    }
}
