using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_988d
    {
        static int Solve()
        {
            int[] nml = Console.ReadLine().Split(' ').
                Select(x=>int.Parse(x)).ToArray();
            int n = nml[0];
            int m = nml[1];
            int l = nml[2];

            //PriorityQueue<int, int> =; 
            for (int i = 0; i < n; i++) 
            { 

            }
            return 0;
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
