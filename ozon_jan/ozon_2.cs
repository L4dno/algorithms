using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.ozon_jan
{
    internal class ozon_2
    {
        public static void Launch()
        {
            Dictionary<char, char[]> trans = new Dictionary<char, char[]>()
            {
                {'m', new char[]{'r','c','d'} },
                {'r', new char[]{'c'} },
                {'c', new char[]{'m'} },
                {'d', new char[]{'m'} }
            };

            using var input = new StreamReader(Console.OpenStandardInput());
            using var output = new StreamWriter(Console.OpenStandardOutput());

            int t = int.Parse(input.ReadLine());
            while (t-- > 0) { 
                string logs = input.ReadLine().ToLower();
                bool success = true;
                for (int i = 0; i < logs.Length - 1; i++) {
                    if (!trans[logs[i]].Contains(logs[i+1])) { 
                        success = false;
                        break;
                    }
                }
                if (logs[logs.Length-1] != 'd' || logs[0] != 'm')
                {
                    success = false;
                }
                    
                if (success)
                    output.WriteLine("YES");
                else
                    output.WriteLine("NO");
            }
        }
    }
}
