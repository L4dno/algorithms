using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lc125
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int n = s.Length;

            for (int l = 0, r = n - 1; l < r; l++, r--)
            {
                while (l < r && !char.IsLetterOrDigit(s[l]))
                    l += 1;
                while (l < r && !char.IsLetterOrDigit(s[r]))
                    r -= 1;
                if (char.ToLower(s[l]) != char.ToLower(s[r]))
                    return false;
            }
            return true;
        }
    }


}

