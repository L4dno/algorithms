using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_6o
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                int[] tsp = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                (int, int)[] sp = new (int,int)[n];
                for (int i = 0;i<n;++i)
                {
                    sp[i] = (tsp[i], i);
                }
                
                int m = int.Parse(input.ReadLine());
                int[] tw = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                int[] fileToServ = new int[m];

                (int, int)[] w = new (int, int)[n];
                for (int i = 0; i < m; ++i)
                {
                    w[i] = (tw[i], i);
                }

                w = w.OrderByDescending(x => x.Item1).ToArray();
                sp = sp.OrderByDescending(sp => sp.Item1).ToArray();

                int ans = 0;

                int servInd = 0;
                int fInd = 1; // первый файл на жеский сервер
                // обозначить в массиве
                int prev = (w[0].Item1 + sp[0].Item1 - 1) / sp[0].Item1;
                while (servInd < n)
                {
                    for (; fInd < m;++fInd)
                    {
                        int cur = (w[fInd].Item1 + sp[servInd].Item1 - 1) / sp[servInd].Item1;
                        while (servInd != n && Math.Abs(cur-prev)!=0) //мб ухудшили, но можно спасти
                        {
                            int next = (w[fInd].Item1 + sp[servInd+1].Item1 - 1) / sp[servInd+1].Item1;
                            if (next >= cur)
                            {
                                // переносим

                            }
                        }
                        ans = Math.Abs(prev - cur);
                    }
                }


                int fileInd = 0;
                int minTime = 0;
                int maxTime = 0;



                for (int i = 0;i<n;++i)
                {
                    while (fileInd < w.Length) {
                        int time = (w[fileInd].Item1 + sp[i].Item1 - 1) / sp[i].Item1;
                    }
                }
            }
        }
    }
}
