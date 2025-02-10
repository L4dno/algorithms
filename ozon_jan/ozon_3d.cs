using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_3d
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
                HashSet<string> usedPrice = new HashSet<string>();

                for (int i = 0; i < n; ++i)
                {
                    string prod = input.ReadLine();
                    string[] np = prod.Split();
                    namePrice.Add(np[0], np[1]);
                }

                string[] prods = input.ReadLine().Split(',');

                bool success = true;
                foreach (string prod in prods) { 
                    if (prod.Length==0)
                    {
                        success = false;
                        break;
                    }
                    string[] np = prod.Split(':');
                    if (np.Length != 2)
                    {
                        success = false;
                        break;
                    }
                    if (!namePrice.ContainsKey(np[0]))
                    {
                        success = false;
                        break;
                    }
                    if (namePrice[np[0]] != np[1])
                    {
                        success = false; break;
                    }
                    if (usedPrice.Contains(np[1]))
                    {
                        success = false; break;
                    }
                    usedPrice.Add(np[1]);
                    namePrice.Remove(np[0]);
                }

                foreach (var leftover in namePrice)
                {
                    if (!usedPrice.Contains(leftover.Value))
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
