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

                in(int, int)[] speed = new (int, int)[n];
                for (int i = 0;i<n;++i)
                    speed[i] = (int.Parse(input.ReadLine()), i);

                int m = int.Parse(input.ReadLine());

                (int,int)[] weight = new (int,int)[m];
                for (int i =0;i<m;++i)
                    weight[i] = (int.Parse(input.ReadLine()), i);

                //speed = speed.OrderByDescending()
            }
        }
    }
}
