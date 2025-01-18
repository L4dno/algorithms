using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.cf
{
    internal class cf_993c
    {
        static public void Launch()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] mabc = Console.ReadLine().Split(' ').
                                Select(x => int.Parse(x)).ToArray();
                int m = mabc[0];
                int a = mabc[1];
                int b = mabc[2];
                int c = mabc[3];

                int res = 0;
                res += Math.Min(m, a);
                res += Math.Min(m, b);
                if (res < 2 * m)
                    res += Math.Min(2 * m - res, c);
                Console.WriteLine(res);
            }
        }
    }
}
