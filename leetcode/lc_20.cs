using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_20
    {
        static public bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();
            char prev = '#';
            foreach (char c in s) {
                switch (c)
                {
                    case '(':
                        brackets.Push(c);
                        break;
                    case '[':
                        brackets.Push(c);
                        break;
                    case '{':
                        brackets.Push(c);
                        break;
                    case ')':
                        
                        if (brackets.Count == 0 || brackets.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        
                        if (brackets.Count == 0 || brackets.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (brackets.Count == 0 || brackets.Pop() != '[')
                            return false;
                        break;
                }
            }
            if (brackets.Count > 0)
                return false;
            return true;
        }
    }
}
