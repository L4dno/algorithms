using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_988c
    {
        public static void Launch()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- > 0)
            {
                
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 5)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    // 1 3 than all odd without 5
                    // 5 4 than all even

                    // but better 
                    // all even from two without 4
                    // than 4 5 and all odds without 5

                    var p = new int[n];
                    p[0] = 1;
                    p[1] = 3;
                    for (int i = 7; i <= n; i += 2)
                        p[(i - 3) / 2] = i;
                    int ind5 = (n - 1) / 2;
                    p[ind5] = 5;
                    p[ind5 + 1] = 4;
                    p[ind5 + 2] = 2;

                    for (int i = 6; i <= n; i += 2)
                        p[ind5 + 3 + (i - 6) / 2] = i;

                    Console.WriteLine(string.Join(" ", p));
                }
            }
        }
    }
}
