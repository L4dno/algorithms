using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

            var obstacles = new List<ValueTuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                int[] lr = Console.ReadLine().Split(' ').
                                        Select(x=>int.Parse(x)).ToArray();
                obstacles.Add((lr[0], lr[1]));
            }
            obstacles.Sort();

            // можно было засунуть в массив препятствий, тк оба сортируются по первой
            // корде без внимания на вторую. Только доп булевая пометка того,
            // к чему относится
            var powers = new List<ValueTuple<int, int>>();
            for (int i = 0;i<m;++i)
            {
                int[] xv = Console.ReadLine().Split(' ').
                                        Select(x => int.Parse(x)).ToArray();
                // sorting by values to have bigger nums first
                // and we can use them if x < l
                powers.Add(( xv[0], xv[1]));
            }
            powers.Sort();

            var collectable_powers = new PriorityQueue<int, int>
                    (Comparer<int>.Create((lhs, rhs) => rhs.CompareTo(lhs)));

            // len of the gap = r-l+2
            int i_power = 0;
            int jump = 1;
            int cnt = 0;
            foreach (var obstacle in obstacles)
            {
                for (; i_power < powers.Count; ++i_power)
                {
                    if (powers[i_power].Item1 > obstacle.Item1)
                        break;
                    collectable_powers.Enqueue(powers[i_power].Item1, 
                        powers[i_power].Item2);
                }

                while ((obstacle.Item2 - obstacle.Item1 + 2) > jump && 
                        collectable_powers.TryDequeue(out int x, out int v))  
                {
                    jump += v;
                    cnt += 1;
                }

                if (collectable_powers.Count == 0 &&
                    (obstacle.Item2 - obstacle.Item1 + 2) > jump)
                {
                    cnt = -1;
                    break;
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
