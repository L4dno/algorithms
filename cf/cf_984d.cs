using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms.cf
{
    internal class cf_984d
    {
        public static int Solve()
        {
            string[] parts = Console.ReadLine().Split(' ');
            int n = int.Parse(parts[0]);
            int m = int.Parse(parts[1]);

            char[,] carpet = new char[n, m];
            for (int i =0;i<n;++i)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < m; ++j)
                    carpet[i, j] = line[j];
            }
           

            int layer = 0;
            
            int cnt = 0;

            while (layer < Math.Min(n/2, m/2))
            {
                int i = layer;
                int j = layer;
                string trace = "";
                while (j<m-layer)
                {
                    // remove first dig and add last
                    trace = trace + carpet[i, j];
                    j += 1;
                }
                i += 1;//to not repeat last elem
                j -= 1;

                while (i < n-layer)
                {
                    trace = trace + carpet[i, j];
                    i += 1;
                }
                j -= 1;
                i -= 1;

                while (j >= layer)
                {
                    trace = trace + carpet[i, j];
                    j -= 1;
                }
                i-= 1;
                j += 1;

                while (i >= layer + 1)
                {
                    trace = trace + carpet[i, j];
                    i -= 1;
                }

                layer += 1;
                //Console.WriteLine(trace);
                trace = trace + trace.Substring(0, 3);

                int ind = trace.IndexOf("1543");
                while (ind != -1)
                {
                    cnt += 1;
                    ind = trace.IndexOf("1543", ind+1);
                }
            }

            
            return cnt;
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
