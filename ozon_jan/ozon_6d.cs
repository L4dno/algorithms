using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_6d
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());

                int[] speed = new int[n];
                for (int i = 0; i < n; ++i)
                    speed[i] = int.Parse(input.ReadLine());

                int m = int.Parse(input.ReadLine());

                int[] weight = new int[m];
                for (int i = 0; i < m; ++i)
                    weight[i] = int.Parse(input.ReadLine());

                List<(int, int)> times = new List<(int, int)>(n * m);
                for (int servInd = 0; servInd < n; ++servInd)
                {
                    for (int fileInd = 0; fileInd < m; ++fileInd)
                    {
                        times.Add(((int)Math.Ceiling((double)weight[fileInd] /
                                                    speed[servInd]), fileInd));
                    }
                }
                times = times.OrderByDescending(x => x.Item1).ToList();
                // проверить вычисление
                // два указателя и переменная для минимума
                // сет для картин
            }
        } 
    }
}
