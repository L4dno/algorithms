using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_6
    {
        static public void Launch()
        {

            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n, m;
                var nm = input.ReadLine().Split();
                n = int.Parse((string)nm[0]);
                m = int.Parse((string)nm[1]);

                var laverings = new List<(int, int)>();

                for (int i = 0; i < m; i++)
                {
                    var ab = input.ReadLine().Split();
                    laverings.Add((int.Parse((string)ab[0]) - 1,
                                    int.Parse((string)ab[1]) - 1));
                }

                var dp = new List<(int, bool)>();
                dp[]

            }

        }

        static public void Fast()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n, m;
                var nm = input.ReadLine().Split();
                n = int.Parse((string)nm[0]);
                m = int.Parse((string)nm[1]);

                var laverings = new List<(int,int)>();
                var turns = new int[n];

                for (int i = 0;i< m; i++)
                {
                    var ab = input.ReadLine().Split();
                    laverings.Add((int.Parse((string)ab[0]) - 1, 
                                    int.Parse((string)ab[1]) - 1));
                    turns[laverings[i].Item1] += 1;
                    turns[laverings[i].Item2] += 1;
                }

                var on = new List<int>();
                for (int i = 0;i<m;++i)
                {
                    if (turns[laverings[i].Item1]%2==0 &&
                        turns[laverings[i].Item2]%2==0)
                    {
                        turns[laverings[i].Item1] -= 1;
                        turns[laverings[i].Item2] -= 1;
                    }
                    else
                    {
                        on.Add(i + 1);
                    }
                }

                int cnt = 0;
                for (int i = 0; i < n; ++i)
                {
                    if (turns[i]%2 != 0)
                        cnt += 1;
                }

                output.WriteLine(cnt);
                output.WriteLine(on.Count);
                output.WriteLine(string.Join(" ", on));
            }

        }
    }
}
