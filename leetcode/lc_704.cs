using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_704
    {
        public int Search(int[] nums, int target)
        {
            int l = -1;
            int r = nums.Length;

            while (r - l > 1)
            {
                int mid = (l + r) / 2;
                if (nums[mid] > target)
                    r = mid;
                else
                    l = mid;
            }
            if (l != -1 && nums[l] == target)
                return l;
            else
                return -1;
        }
    }
}
