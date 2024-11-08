using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lc15
{
    public class Solution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            // m всегда от l??
            int n = nums.Length;
            Array.Sort(nums);

            List<List<int>> res = new List<List<int>>();

            for (int l = 0, r = n - 1; l < r;l++)
            {
                int m = l + 1;
                // while r is too large
                while (m < r && nums[l] + nums[m] + nums[r] > 0) r -= 1;
                // while l+m are too small
                while (m < r && nums[l] + nums[m] + nums[r] < 0)
                {
                    m += 1;
                }
                if (nums[l] + nums[m] + nums[r] == 0)
                {
                    res.Add(new List<int> { nums[l], nums[r], nums[m] });
                    ++l;
                    r--;
                }
            }
            return res;
        }
    }

}
