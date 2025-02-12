using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_6d
    {
        struct Duration
        {
            public int time;
            public int server;
            public int file;

            public Duration(int t, int s, int f)
            {
                time = t; server = s; file = f;
            }
        }
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                int[] speed = input.ReadLine().Split().Select(x=>int.Parse(x)).ToArray();

                int m = int.Parse(input.ReadLine());
                int[] weight = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                List<Duration> times = new List<Duration>(n * m);
                for (int servInd = 0; servInd < n; ++servInd)
                {
                    for (int fileInd = 0; fileInd < m; ++fileInd)
                    {
                        int time = (int)Math.Ceiling((double)weight[fileInd]/speed[servInd]);
                        times.Add(new Duration(time, servInd, fileInd));
                    }
                }
                times = times.OrderByDescending(x => x.time).ToList();
                // проверить вычисление
                // два указателя и переменная для минимума
                // сет для картин

                int[] fileToServMin = new int[m];
                int difMin = 1000000000;

                int sentCnt = 0;
                int[] usedFiles = new int[m];

                int r = 0;
                for (int l = 0;l<n*m;++l)
                {
                    // пока можем доотправить файлы и ещё не все отправили
                    // перескакиваем через файл почемуто
                    while (r<n*m && sentCnt < m)
                    {
                        
                        usedFiles[times[r].file] += 1;
                        if (usedFiles[times[r].file] == 1)
                            sentCnt++;

                        if (r < n * m && times[l].time - times[r].time < difMin)
                        {
                            difMin = times[l].time - times[r].time;
                            Console.WriteLine(difMin);
                            for (int k = l; k < r; ++k)
                            {
                                fileToServMin[times[k].file] = times[k].server;
                            }
                        }
                        // добавляем в счетчик
                        // либо удаляем
                        // обновляем cnt
                        r++;
                    }
                    
                    usedFiles[times[l].file] -= 1;
                    if (usedFiles[times[l].file] == 0)
                        sentCnt--;
                }


                output.WriteLine(difMin);
                output.WriteLine(string.Join("", fileToServMin));
            }
        } 
    }
}
