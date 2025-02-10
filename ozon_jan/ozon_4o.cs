using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_4o
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

                for (int i = 0;i < n; i++)
                {
                    string ep = "";
                    string op = "";

                    string s = input.ReadLine();
                    for (int j = 0;j<s.Length;++j)
                    {
                        if (j%2==0)
                        {
                            ep += s[j];
                        }
                        else
                        {
                            op += s[j];
                        }
                    }
                    
                    

                    if (even.ContainsKey(ep))
                    {
                        even[ep] += 1;
                    }
                    else
                    {
                        even.Add(ep, 1);
                    }

                    if (op == "")
                        continue;

                    if (!odd.ContainsKey(op)) { 
                        odd.Add(op, 1);
                    }
                    else
                    {
                        odd[op] += 1;
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

                int ans = 0;
                foreach (var tmp in even)
                {
                    ans += tmp.Value * (tmp.Value - 1) / 2;
                }
                foreach( var tmp in odd)
                {
                    ans += tmp.Value * (tmp.Value - 1) / 2;
                }
                foreach(var tmp in rep)
                {
                    if (odd.Count != 0)
                    ans -= tmp.Value * (tmp.Value - 1) / 2;
                }

                output.WriteLine(ans);
            }
        }
    }
}
