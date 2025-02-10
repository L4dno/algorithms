using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.nlogn
{
    internal class aplusb
    {
        public static void Launch()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] ab = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int a = ab[0];
                int b = ab[1];
                Console.WriteLine(a + b);
            }
        }
    }
}
