using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace algo.cf
{
    internal class cf_988f
    {
        static int Solve()
        {
            var nmk = Console.ReadLine().Split(' ').
                Select(x => Convert.ToInt32(x)).ToArray();
            int n = nmk[0];
            int m = nmk[1];
            int k = nmk[2];

            int[] health = Console.ReadLine().Split(' ').
                Select(x => int.Parse(x)).ToArray();
            int[] positions = Console.ReadLine().Split(' ').
                Select(x=> int.Parse(x)).ToArray();

            int winSize = 2 * m - 1;

            int l = 0, r = (int)2e9;
            while (r - l>1)
            {
                int mid = (r + l) / 2;

                var line = new Dictionary<int, int>();
                for (int i = 0; i < n; ++i)
                {
                    int ma = (health[i] + mid - 1) / mid;
                    if (ma > m)
                        continue;
                    int lhs = positions[i] - m + ma;
                    int rhs = positions[i] + m - ma + 1;
                    line[lhs] = (line.ContainsKey(lhs) ? line[lhs] : 0) + 1;
                    line[rhs] = (line.ContainsKey(rhs) ? line[rhs]:0) - 1;
                }
                int sc = 0;
                foreach(var kvp in line.OrderBy(kvp => kvp.Key))
                {
                    sc += line[kvp.Key];
                    if (sc >=k)
                    {
                        r = mid;
                        break;
                    }
                }
                if (r != mid)
                    l = mid;
            }
            if (r == (int)2e9) 
                return -1;
            else
                return r;
        }
        public static void Launch()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                Console.WriteLine(Solve());
            }
        }
    }
}
