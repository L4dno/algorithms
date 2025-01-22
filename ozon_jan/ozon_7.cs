using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_7
    {
        struct Point2
        {
            public int x = 0; 
            public int y = 0;

            public Point2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static public void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while ( t-- > 0)
            {
                int[] nm = input.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();
                int n = nm[0];
                int m = nm[1];

                int[,] field = new int[n, m];
                Point2 aPos;
                Point2 bPos;
                for (int i = 0;i<n;++i)
                {
                    for (int j = 0;j<m;++j)
                    {
                        char c = (char)input.Read();
                        if (c == '.' || c == '#')
                            field[i, j] = c;
                        else if (c == 'A')
                        {
                            aPos = new Point2(i, j);
                            field[i, j] = c;
                        }
                        else
                        {
                            bPos = new Point2(i, j);
                            field[i, j] = c;
                        }
                    }
                }
            
                
            }
        }
    }
}
