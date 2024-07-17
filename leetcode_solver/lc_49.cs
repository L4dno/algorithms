using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

    public class Solution
    {
        const int AlphSize = 26;
        public int[] CntLetters(string str)
        {
            int[] res = new int[AlphSize];
            foreach (char ch in str)
            {
                res[(int)ch - 97] += 1;
            }
            return res;
        }

        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var res = new Dictionary<int[], List<string>>();

            foreach (var str in strs)
            {
                var tmp = CntLetters(str);
                if (res.ContainsKey(tmp))
                {
                    res[tmp].Add(str);
                }
                else
                {
                    res[tmp] = new List<string> { str };
                }
            }
            return res.Values.ToList();
        }
    }


    public static class _0049GroupAnagrams
{
        static public int Tcnt = 3;
        public static List<string[]> Inputs = new List<string[]>()
    {
        new string[] {"act","pots","tops","cat","stop","hat"},
        new string[] {"x"},
        new string[] {""}
    };
        public static List<List<List<string>>> ExpectedOutputs = new List<List<List<string>>>()
    {
        new List<List<string>>
        {
            new List<string> {"hat"},
            new List<string> {"act", "cat"},
            new List<string> {"stop", "post", "tops"}
        },
        new List<List<string>>
        {
            new List<string> {"x"}
        },
        new List<List<string>>
        {
            new List<string>{""}
        }
    };
    }

