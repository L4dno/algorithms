using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_6
    {
        // graph and number of edges
        static List<(int, int)>[] g;
        static bool[] color;
        static int ons;
        static List<int> levers;
        static int dfs(int v, bool isFirstInComponent, int numLever)
        {
            int childSum = 0;
            color[v] = true;
            foreach (var p in g[v])
            {
                if (color[p.Item1] == false)
                    childSum += dfs(p.Item1, false, p.Item2);
            }
            childSum %= 2;
            // зажигаем
            if (childSum == 0)
            {
                if (!isFirstInComponent)
                {
                    ons += 1;
                    levers.Add(numLever+1);//мы добавляем номер ребра, а не вершину
                }
                return 1;
            }
            else
            {
                ons += 1;
                return 0;
            }
            
        }
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

                g = new List<(int, int)>[n];
                color = new bool[n];
                ons = 0;
                levers = new List<int>();

                for (int vertInd = 0;vertInd < n;++vertInd)
                {
                    g[vertInd] = new List<(int, int)>();
                }

                for (int i = 0; i < m; i++)
                {
                    var ab = input.ReadLine().Split();
                    int a = int.Parse(ab[0]) - 1;
                    int b = int.Parse(ab[1]) - 1;
                    g[a].Add((b, i));
                    g[b].Add((a, i));
                }

                // dfs?
                // components change in picking edges
                for (int vertInd = 0; vertInd < n; ++vertInd)
                {
                    if (color[vertInd] == false)
                        dfs(vertInd, true, -1);
                }

                Console.WriteLine(ons);
                Console.WriteLine(levers.Count);
                Console.WriteLine(string.Join(" ", levers));
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
