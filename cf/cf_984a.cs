using System;
using System.Collections.Generic;
using System.Linq;

namespace cf_984
{
	public class Solution
	{
		public static void Launch()
		{
			int t = 0;
			t = Convert.ToInt32(Console.ReadLine());

			int n = 0;
			var melody = new List<int>();
			while (t-- > 0)
			{
				n = Convert.ToInt32(Console.ReadLine());
				melody = Console.ReadLine()
								.Split(' ')
								.Select(int.Parse)
								.ToList();

				int i = 0;
                for (; i < n; i++)
				{
					if (i > 0 && (Math.Abs(melody[i]-melody[i-1])!=5 && 
						Math.Abs(melody[i] - melody[i - 1]) != 7))
					{
						Console.WriteLine("NO");
						break;
					}
				}
				if (i==n)
					Console.WriteLine("YES");
			}
		}
	}
}