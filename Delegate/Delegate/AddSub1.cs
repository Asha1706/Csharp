using System;
namespace Delegate
{
    internal delegate void AddDelegate(int x, int y);
    internal delegate void SubDelegate(int x, int y);
    internal class AddSub1
    {
        internal void Add(int x, int y)
        {
            Console.WriteLine(x +y);
        }
        internal void Sub(int x,int y)
        {
            Console.WriteLine(x -y);
        }
        static void Main()
        {
            AddSub1 addSub1 = new AddSub1();
            AddDelegate obj = new AddDelegate(addSub1.Add);
            SubDelegate obj1 = new SubDelegate(addSub1.Sub);
            obj(23, 65); obj(65, 87); obj1(116, 89); obj1(54, 67);
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj1.ToString());
            Console.ReadLine();

        }

    }
}
