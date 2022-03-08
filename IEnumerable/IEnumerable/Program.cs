using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> Month = new List<string>();
        Month.Add("January");
        Month.Add("February");
        Month.Add("March");
        Month.Add("April");
        Month.Add("May");
        Month.Add("June");
        Month.Add("July");
        Month.Add("August");
        Month.Add("September");
        Month.Add("October");
        Month.Add("November");
        Month.Add("December");
        IEnumerable<string> iEnumerableOfString = (IEnumerable<string>)Month;
        foreach (string AllMonths in iEnumerableOfString)
        {
            Console.WriteLine(AllMonths);
            
        }
        IEnumerator<string> iEnumeratorOfString = Month.GetEnumerator();

          
        while (iEnumeratorOfString.MoveNext())
        {
            Console.WriteLine(iEnumeratorOfString.Current);
        }
    }
   

}
