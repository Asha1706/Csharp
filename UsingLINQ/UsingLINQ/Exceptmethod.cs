using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    internal class Exceptmethod
    {
        static void Main(string[] args)
        {
            List<char> list1 = new List<char>();
            List<char> list2 = new List<char>();

            list1.Add('A');
            list1.Add('R');
            list1.Add('D');
            list1.Add('F');
            list1.Add('H');
            list1.Add('G');

            list2.Add('A');
            list2.Add('J');
            list2.Add('R');
            list2.Add('F');
            list2.Add('M');
            list2.Add('S');

            var query = (from num in list1
                         select num)
                        .Except(list2).ToList();

            foreach (var val in query)
            {
                Console.WriteLine(val);
            }
        }
    }
}
