using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Class2
    {
        static void Main()
        {
            string[] arr = { "red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };
            var coll1 = from s in arr select s;                       //Gets the list of all colors as is
            var coll2 = from s in arr orderby s select s;               //Gets the list of all colors in ascending order
            var coll3 = from s in arr orderby s descending select s;    //Gets the list of all colors in descending order
            var coll4 = from s in arr orderby s ascending select s;     //Gets the list of all colors in ascending order
            var coll5 = from s in arr where s.Length == 4 select s;     //Gets the list of colors whose length is 5 characters
            Console.WriteLine(String.Join(" ", coll1));
            Console.WriteLine(String.Join(" ", coll2));
            Console.WriteLine(String.Join(" ", coll3));
            Console.WriteLine(String.Join(" ", coll4));
            Console.WriteLine(String.Join(" ", coll5));
            Console.WriteLine("---------------------------------");
            //Getting the list of arr whose name starts with character "B":
            var coll6 = from s in arr where s[0] == 'B' select s;
             var coll7 = from s in arr where s.StartsWith("B") select s;
             var coll8 = from s in arr where s.Substring(0, 1) == "B" select s;
             var coll9 = from s in arr where s.IndexOf("B") == 0 select s;
            Console.WriteLine(String.Join(" ", coll6));
            Console.WriteLine(String.Join(" ", coll7));
            Console.WriteLine(String.Join(" ", coll8));
            Console.WriteLine(String.Join(" ", coll9));
            Console.WriteLine("---------------------------------");

            //Getting the list of arr whose name ends with character "e":
            var coll10 = from s in arr where s.EndsWith("e") select s;
            var coll11 = from s in arr where s[s.Length - 1] == 'e' select s;
            var coll12 = from s in arr where s.Substring(s.Length - 1) == "e" select s;
            var coll13 = from s in arr where s.LastIndexOf("e") == s.Length - 1 select s;
            Console.WriteLine(String.Join(" ", coll10));
            Console.WriteLine(String.Join(" ", coll11));
            Console.WriteLine(String.Join(" ", coll12));
            Console.WriteLine(String.Join(" ", coll13));
            Console.WriteLine("---------------------------------");
            //Getting the list of arr whose name contains character "a" at 3rd place: 
            var coll14 = from s in arr where s[2] == 'a' select s;
            var coll15 = from s in arr where s.IndexOf("a") == 2 select s;
            var coll16 = from s in arr where s.Substring(2, 1) == "a" select s;
            Console.WriteLine(String.Join(" ", coll14));
            Console.WriteLine(String.Join(" ", coll15));
            Console.WriteLine(String.Join(" ", coll16));
            Console.WriteLine("---------------------------------");
            //Getting the list of arr whose name contains character "o" in it: 
            var coll17 = from s in arr where s.Contains('o') || s.Contains('O') select s;
            var coll18 = from s in arr where s.IndexOf('o') >= 0 || s.IndexOf('O') >= 0 select s;
            var coll19 = from s in arr where s.ToLower().Contains('o') select s;
            var coll20 = from s in arr where s.ToUpper().IndexOf('O') >= 0 select s;
            Console.WriteLine(String.Join(" ", coll17));
            Console.WriteLine(String.Join(" ", coll18));
            Console.WriteLine(String.Join(" ", coll19));
            Console.WriteLine(String.Join(" ", coll20));
            Console.WriteLine("---------------------------------");
            //Getting the list of arr whose name dosn't contains character "o" in it: 

            var coll21 = from s in arr where s.IndexOf('o') == -1 && s.IndexOf('O') == -1 select s;
            var coll22 = from s in arr where s.Contains('o') == false && s.Contains('O') == false select s;
            var coll23 = from s in arr where s.ToUpper().Contains('O') == false select s;
            var coll24 = from s in arr where s.ToLower().IndexOf('o') == -1 select s;
            Console.WriteLine(String.Join(" ", coll21));
            Console.WriteLine(String.Join(" ", coll22));
            Console.WriteLine(String.Join(" ", coll23));
            Console.WriteLine(String.Join(" ", coll24));
            Console.ReadLine();
        

           

        }
    }
}