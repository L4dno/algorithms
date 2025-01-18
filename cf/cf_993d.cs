using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.cf
{
    internal class cf_993d
    {
        static public void Launch()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var mex = new SortedSet<int>();
                for (int i = 0; i < n; i++)
                {
                    mex.Add(i + 1);
                }

                var uniq = new List<int>();
                foreach (var ai in a)
                {
                    if (mex.Contains(ai))
                    {
                        uniq.Add(ai);
                        mex.Remove(ai);
                    }
                }
                int dif = n - mex.Count; // сколько уникальных в a

                while (n%dif!=0)
                {
                    dif += 1;
                }

                var res = new List<int>();
                int cnt_one = n / dif; // сколько раз повторять числа

                foreach (var un in uniq)
                {
                    for (int i = 0; i < cnt_one; i++)
                    {
                        res.Add(un);
                    }
                }

                while (mex.Count > 0 && res.Count != n) {
                    for (int i = 0; cnt_one > i; i++)
                    {
                        res.Add(mex.Min());
                        mex.Remove(mex.Min());
                    }
                }

                Console.WriteLine(string.Join(" ", res) + '\n');
            }
        }
    }
}
