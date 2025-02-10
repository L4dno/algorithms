using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_1o
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int[] nm = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int n = nm[0];
                int m = nm[1];

                (int, int) p1 = (n, 1);
                (int, int) p2 = (1, m);

                // вертикаль
                if (n > m) {
                    if (m==1)
                    {
                        output.WriteLine(1);
                        output.WriteLine(p1.Item1.ToString() + " " + p1.Item2.ToString() + " U");
                    }
                    else
                    {
                        output.WriteLine(2);
                        output.WriteLine(p1.Item1.ToString() + " " + p1.Item2.ToString() + " U");
                        output.WriteLine(p2.Item1.ToString() + " " + p2.Item2.ToString() + " D");
                    }
                }
                else // горизонталь
                {
                    if (n==1)
                    {
                        output.WriteLine(1);
                        output.WriteLine(p2.Item1.ToString() + " " + p2.Item2.ToString() + " L");
                    }
                    else
                    {
                        output.WriteLine(2);
                        output.WriteLine(p1.Item1.ToString() + " " + p1.Item2.ToString() + " R");
                        output.WriteLine(p2.Item1.ToString() + " " + p2.Item2.ToString() + " L");

                    }
                }
            }
        }
    }
}
