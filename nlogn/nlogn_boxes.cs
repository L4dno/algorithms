using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.nlogn
{
    internal class nlogn_boxes
    {
        static public void Launch()
        {
            int n = int.Parse(Console.ReadLine());

            (int, int)[] cw = new (int, int)[n];
            for (int i = 0; i < n; i++)
            {
                int[] inp = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                cw[i].Item1 = inp[0];
                cw[i].Item2 = inp[1];
            }
            //cw = cw.OrderBy(x => x.Item1);
        }
    }
}
