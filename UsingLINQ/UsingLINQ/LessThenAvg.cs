using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLINQ
{
    internal class LessThenAvg
    {
		static void Main()
		{

		
			int[] Arr = { 123, 23, 234, 546, 786, 345, 809, 12, 4 };

			
			int total = Arr.Sum();

	
			int avg = total / Arr.Length;

	
			var nums = from num in Arr where num < avg select num;

			
			Console.WriteLine("Average is " + avg);
			Console.WriteLine("The Numbers:");
			foreach (int n in nums)
			{
				Console.Write(n + " ");
			}
			Console.WriteLine();
		}
	}
}

