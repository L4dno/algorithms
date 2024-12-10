using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_984f
    {

        private static long GetXOR(long n)
        {
            long x = ((n % 4) + 4) % 4;

            switch (x)
            {
                case 0: return n;
                case 1: return 1;
                case 2: return n+1;
                default: return 0;
            }
        }

        static long XorRange(long l, long r)
        {
            long lhs = GetXOR(l - 1);
            long rhs = GetXOR(r);
            long tmp = lhs ^ rhs;
            return tmp;  
        }

        public static long Solve(long l, long r, int i, int k)
        {

            long xlr = XorRange(l, r);
            Console.WriteLine(xlr);

            long shl = l >> i;
            long shr = r >> i;

            long xshlr = XorRange(l,r);
            xshlr = xshlr << i;
            Console.WriteLine(xshlr);

            int bad_cnt_r = 1 + (int)(r - k) / (1 << i);
            int bad_cnt_l = 1 + (int)(l-1 - k) / (1 << i);
            int bad_cnt = bad_cnt_r - bad_cnt_l;
            Console.WriteLine(bad_cnt);

            //int bad_cnt = 1 + Convert.ToInt32(Math.Floor(Convert.ToDouble(r - k) 
            //                                / Convert.ToDouble(1 << i)));
            if (bad_cnt%2==1)
            {
                // odd xors for last i bits
                return xlr ^ (xshlr | k);
            }
            else
            {
                return xlr ^ xshlr;
            }
        }

        public static void Launch()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                string[] parts = Console.ReadLine().Split(' ');
                long l = Int64.Parse(parts[0]);
                long r = Int64.Parse(parts[1]);

                int i = Int32.Parse(parts[2]);
                int k = Int32.Parse(parts[3]);

                Console.WriteLine(Solve(l, r, i, k));
            }
        }

    }
}
