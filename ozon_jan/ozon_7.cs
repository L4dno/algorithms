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

            public Point2()
            {
                this.x = 0;
                this.y = 0;
            }
            public int Manh(Point2 rhs)
            {
                return int.Abs(x - rhs.x) + int.Abs(y - rhs.y);
            }
        }

        static int n = 0;
        static int m = 0;

        static void toLeft(ref char[,] field, char robot, ref Point2 cur)
        {
            while (cur.x > 0 && field[cur.x - 1, cur.y] != '#')
            {
                cur.x -= 1;
                field[cur.x, cur.y] = robot;
                
            }
            while (cur.y > 0 && field[cur.x, cur.y - 1] != '#')
            {
                cur.y -= 1;
                field[cur.x, cur.y] = robot;
                
            }
        }

        static void toRight(ref char[,] field, char robot, ref Point2 cur)
        {
            while (cur.x < n - 1 && field[cur.x + 1, cur.y] != '#')
            {
                cur.x += 1;
                field[cur.x, cur.y] = robot;
                
            }
            while (cur.y < m - 1 && field[cur.x, cur.y + 1] != '#')
            {
                cur.y += 1;
                field[cur.x, cur.y] = robot;
                
            }
        }

        static public void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int[] nm = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                n = nm[0];
                m = nm[1];

                char[,] field = new char[n, m];
                Point2 aPos = new Point2();
                Point2 bPos = new Point2();

                for (int i = 0; i < n; ++i)
                {
                    string row = input.ReadLine();
                    for (int j = 0; j < m; ++j)
                    {
                        char c = row[j];
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

                Point2 leftUp = new Point2(0, 0);
                Point2 rightDown = new Point2(n-1, m-1);

                int aLeftDist = aPos.Manh(leftUp);
                int bLeftDist = bPos.Manh(leftUp);

                if (aLeftDist <= bLeftDist)
                {
                    // А идет наверх

                    toLeft(ref field, 'a', ref aPos);
                    toLeft(ref field, 'a', ref aPos);

                    toRight(ref field, 'b', ref bPos);
                    toRight(ref field, 'b', ref bPos);

                }
                else
                {
                    // А идет вниз

                    toLeft(ref field, 'b', ref bPos);
                    toLeft(ref field, 'b', ref bPos);

                    toRight(ref field, 'a', ref aPos);
                    toRight(ref field, 'a', ref aPos);
                }

                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        output.Write(field[i, j]);
                    }
                    output.WriteLine();
                }
            }
        }
    }
}
