using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_4s
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                string[] words = new string[n];
                foreach (ref var st in words.AsSpan())
                {
                    st = input.ReadLine();
                }

                int ans = 0;
                for (int i = 0;i<n;++i) {
                    for (int j = i+1;j<n;++j)
                    {
                        ref string first = ref words[i];
                        ref string second = ref words[j];
                        if (words[i].Length < words[j].Length)
                        {
                            first = ref words[j];
                            second = ref words[i];
                        }

                        bool even = true;
                        for (int k = 0;k<first.Length;k+=2)
                        {
                            if (first[k] != (k<second.Length ? second[k] : '#')) { 
                                even = false; break;    
                            }
                        }

                        bool odd = first.Length > 1 ? true : false;
                        for (int k = 1; k < first.Length; k += 2)
                        {
                            if (first[k] != (k < second.Length ? second[k] : '#'))
                            {
                                odd = false; break;
                            }
                        }
                        if (odd || even) {
                            ans += 1;
                        }
                       
                    }
                }

                output.WriteLine(ans);
            }
        }
    }
}
