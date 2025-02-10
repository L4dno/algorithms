using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_2o
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                string n = input.ReadLine();
                if (n.Length == 1)
                {
                    output.WriteLine((n[0] - '0') + 1);
                }
                else
                {
                    int ans = 10 * (n.Length - 1);
                    for (int i = 1; i < n.Length; i++)
                    {
                        ans += int.Min(n[0] - '0', n[i] - '0');
                    }
                    output.WriteLine(ans);
                }
            }
        }
    }
}
