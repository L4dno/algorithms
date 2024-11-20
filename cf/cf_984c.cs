using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.cf
{
    internal class cf_984c
    {
        static bool hasSeq(char[] s, int i) {
            if (s[i]=='1' && s[i + 1] == '1' && s[i+2]=='0' &&
                s[i+3]=='0')
            {
                return true;
            }
            return false;
        }
        static void Solution()
        {
            var s = Console.ReadLine().ToCharArray();
            int q = Convert.ToInt32(Console.ReadLine());

            var iv = new List<int>();

            HashSet<int> startsIn = new HashSet<int>();
            for (int i = 0; i < s.Length - 3; i++)
            {
                if (hasSeq(s, i))
                {
                    startsIn.Add(i);
                }
            }

            while (q-- > 0)
            {
                iv = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList<int>();
                iv[0] -= 1;
                if (s[iv[0]] != Convert.ToChar(iv[1] + 48))
                {
                    //Console.WriteLine("-------\n" + iv[0].ToString() + "\n-------");
                    s[iv[0]] = Convert.ToChar(iv[1] + 48);
                    // i-k start pos for 1100
                    for (int k = 0;k<4;k++)
                    {
                        if (iv[0]-k >= 0 && iv[0]-k+3 < s.Length)
                        {
                            if (startsIn.Contains(iv[0]-k)) 
                                {
                                startsIn.Remove(iv[0] - k);
                            }
                            else if (hasSeq(s, iv[0]-k))
                            {
                                startsIn.Add(iv[0]-k); 
                            }
                        }
                    }
                }
                //Console.WriteLine(startsIn.Count());
                if (startsIn.Count()==0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }

        public static void Main()
        {
            int t = 0;
            t = Convert.ToInt32(Console.ReadLine());

            while (t-- > 0)
            {
                Solution();
            }
        }
    }
}
