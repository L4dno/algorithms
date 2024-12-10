using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_988b
    {
        static int[] Solve()
        {
            int k = Convert.ToInt32(Console.ReadLine());
            var inp = Console.ReadLine().Split(' ').
                        Select(x => int.Parse(x)).ToArray();

            int target = k - 2;
            var Factors = new HashSet<int>();

            foreach (var rhs in inp)
            {
                int lhs = target / rhs;
                if (Factors.Contains(lhs) && lhs*rhs==target)
                {
                    return new int[] { lhs, rhs };
                }
                else
                {
                    Factors.Add(rhs);
                }
            }

            return new int[]{-1,-1};
        }
        static public void Launch()
        {
            int t= Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                var nm = Solve();
                Console.WriteLine(string.Join(" ", nm));
            }
        }
    }
}
