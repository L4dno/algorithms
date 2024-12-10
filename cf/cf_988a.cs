using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_988a
    {
        static int Solve()
        {
            int res = 0;

            int n = int.Parse(Console.ReadLine());
            var Entries = new int[n];

            string[] parts = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++) 
            {
                Entries[int.Parse(parts[i])-1] += 1;
            }
            for (int i = 0; i < n; ++i)
            {
                res += Entries[i] / 2;
            }
            return res;

        }
        public static void Launch()
        {
            int t = Convert.ToInt32((Console.ReadLine()));
            while (t-- > 0)
            {
                Console.WriteLine(Solve());
            }
        }
    }
}
