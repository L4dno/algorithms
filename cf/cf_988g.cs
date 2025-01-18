using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.cf
{
    internal class cf_988g
    {
        static List<int> Factorize(int n)
        {
            List<int> p = new List<int>();
            int i = 2;
            while (i*i<=n)
            {
                if (n%i==0)
                {
                    p.Add(i);
                }
                while (n%i==0)
                {
                    n /= i;
                }
                i += 1;
            }
            if (n > 1)
            {
                p.Add(n);
            }
            return p;
        }

        static List<(int, int)> GetDividers(List<int> arr)
        {
            List<(int, int)> divs = new List<(int, int)>();
            int n = arr.Count;

            for (int subset = 1;subset< (1<<n);++subset)
            {
                int div = 1;
                int ones = 0;
                for (int bit = 0; bit < n;++bit)
                {
                    if ((subset & (1<<bit)) != 0)
                    {
                        div *= arr[bit];
                        ones += 1;
                    }
                }
                divs.Add((div, ones));
            }
            return divs;
        }
        public static void Launch()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int mod = 998244353;

            int[] dp = new int[n];
            // we can get to the first town at the beginning
            dp[0] = 1;

            int[] count = new int[(int)1e6];

            // starts with 1st vertex
            // just to increase count
            for (int i = 0;i< n; i++)
            {
                // dp[i] = sum of count by prime combs
                List<int> p = Factorize(a[i]);
                List<(int, int)> composeMultipliers = GetDividers(p);

                for (int i_mul = 0;i_mul<composeMultipliers.Count;i_mul++)
                {
                    if (composeMultipliers[i_mul].Item2 % 2 == 1)
                    {
                        dp[i] += count[composeMultipliers[i_mul].Item1];
                        dp[i] %= mod;
                    }
                    else
                    {
                        dp[i] -= count[composeMultipliers[i_mul].Item1];
                        dp[i] = (mod + dp[i]) % mod;
                    }
                    
                }
                for (int i_mul = 0; i_mul < composeMultipliers.Count; i_mul++)
                {
                    count[composeMultipliers[i_mul].Item1] += dp[i];
                    count[composeMultipliers[i_mul].Item1] %= mod;
                }
            }

            Console.WriteLine(dp[n-1]);
        }
    }
}
