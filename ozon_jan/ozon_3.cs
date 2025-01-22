using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_3
    {
        static public void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                int[] a = input.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Array.Sort(a);

                StringBuilder sb = new StringBuilder();
                for (int i = 0;i<n;i++)
                {
                    if (i != 0)
                        sb.Append(" ");
                    sb.Append(a[i]);   
                }

                string outValidate = input.ReadLine();
                
                if (sb.ToString() == outValidate)
                {
                    output.WriteLine("yes");
                }
                else
                {
                    output.WriteLine("no");
                }
            }
        }
    }
}
