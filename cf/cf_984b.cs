using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_984b
    {
        public static int Sol()
        {

            var tmp = Console
                            .ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList<int>();
            int n = tmp[0];
            int k = tmp[1];
            // можно было создать массив
            // затем отсортировать в обратном порядке
            // и сложить k первых элементов

            Dictionary<int,int> codeToProfit = new Dictionary<int,int>();

            for (int i = 0;i<k;++i)
            {
                // brand b and cost c
                tmp = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToList<int>();
                if (codeToProfit.ContainsKey(tmp[0]))
                {
                    codeToProfit[tmp[0]] += tmp[1];
                }
                else
                {
                    codeToProfit[tmp[0]] = tmp[1];
                }
            }

            // не можем все бренды уместить
            if (k > n) {
                return codeToProfit
                                    .OrderByDescending(kvp => kvp.Value)
                                    .Take(n)
                                    .Select(kvp=>kvp.Value)
                                    .ToList()
                                    .Sum();
            }
            return codeToProfit.Select(kvp => kvp.Value).ToList().Sum();
        }
        public static void Launch()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0) 
            {
                Console.WriteLine(Sol());
            }
        }
    }
}
