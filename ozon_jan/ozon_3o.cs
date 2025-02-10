using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_3o
    {
        public static void Launch()
        {
            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(input.ReadLine());
                Dictionary<string, string> namePrice = new Dictionary<string, string>();
                Dictionary<string, int> occurs = new Dictionary<string, int>();

                for (int i = 0;i<n;++i)
                {
                    string prod = input.ReadLine();
                    string[] np = prod.Split();
                    namePrice.Add(np[0], np[1]);
                    if (!occurs.ContainsKey(np[1]))
                        occurs.Add(np[1], 0);
                }

                string[] prods = input.ReadLine().Split(',');
                int cnt = prods.Length;

                bool success = true;

                if (prods[cnt-1].Length == 0)
                {
                    // пустая строка
                    success = false;
                }
                else
                {
                    
                    for (int i = 0;i<cnt;++i)
                    {
                        string[] prod = prods[i].Split(':');
                        if (prod.Length != 2)
                        {
                            success = false;
                            break;
                        }

                        if (!occurs.ContainsKey(prod[1]))
                        {
                            success = false;
                            break;
                        }
                        else
                        {
                            occurs[prod[1]] += 1;
                        }
                        if (!namePrice.ContainsKey(prod[0]) || namePrice[prod[0]] != prod[1])
                        {
                            success = false;
                            break;
                        }
                        else
                        {
                            namePrice.Remove(prod[0]);
                        }
                    }
                    foreach (var oc in occurs)
                    {
                        if (oc.Value != 1)
                        {
                            success = false;
                            break;
                        }
                    }

                    if (success)
                    {
                        
                        output.WriteLine("YES");
                    }
                    else
                    {
                        output.WriteLine("NO");
                    }
                }
            }
        }
    }
}
