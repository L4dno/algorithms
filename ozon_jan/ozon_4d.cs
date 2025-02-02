using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_4d
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                Dictionary<string, int> even = new Dictionary<string, int>();
                Dictionary<string, int> odd = new Dictionary<string, int>();
                Dictionary<string, int> rep = new Dictionary<string, int>();

                for (int i = 0; i < n; i++)
                {
                    StringBuilder ep = new StringBuilder();
                    StringBuilder op = new StringBuilder();

                    string s = input.ReadLine();
                    for (int j = 0; j < s.Length; ++j)
                    {
                        if (j % 2 == 0)
                        {
                            ep.Append(s[j]);
                        }
                        else
                        {
                            op.Append(s[j]);
                        }
                    }

                    string eps = ep.ToString();
                    string ops = op.ToString();

                    if (even.ContainsKey(eps))
                    {
                        even[eps] += 1;
                    }
                    else
                    {
                        even.Add(eps, 1);
                    }

                    if (ops == "")
                        continue;

                    if (!odd.ContainsKey(ops))
                    {
                        odd.Add(ops, 1);
                    }
                    else
                    {
                        odd[ops] += 1;
                    }

                    if (rep.ContainsKey(s))
                    {
                        rep[s] += 1;
                    }
                    else
                    {
                        rep.Add(s, 1);
                    }

                }

                long ans = 0;
                foreach (var tmp in even)
                {
                    ans += (long)tmp.Value * (tmp.Value - 1) / 2;
                }
                foreach (var tmp in odd)
                {
                    ans += (long)tmp.Value * (tmp.Value - 1) / 2;
                }
                foreach (var tmp in rep)
                {
                    if (odd.Count != 0)
                        ans -= (long)tmp.Value * (tmp.Value - 1) / 2;
                }

                output.WriteLine(ans);
            }
        }
    }
}
