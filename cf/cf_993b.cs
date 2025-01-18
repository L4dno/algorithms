using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.cf
{
    internal class cf_993b
    {
        public static void Launch()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string a = Console.ReadLine();
                Stack<char> s = new Stack<char>();
                foreach (char c in a)
                {
                    s.Push(c);
                }
                while (s.Count > 0)
                {
                    char c = s.Pop();
                    if (c == 'p')
                        Console.Write('q');
                    else if (c == 'q')
                        Console.Write('p');
                    else
                        Console.Write(c);
                }
                Console.Write('\n');
            }
        }
    }
}
