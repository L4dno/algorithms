using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_2d
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
                    string div = new string('1', n.Length);
                    ans += int.Parse(n) / int.Parse(div); 
                    output.WriteLine(ans);
                }
            }
        }
    }
}
