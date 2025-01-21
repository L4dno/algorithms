//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using static algo.leetcode.lc_534;

//namespace algo.leetcode
//{
//    internal class lc_104
//    {
//        public class Solution
//        {
//            int mx = -1;
//            void dfs(TreeNode n, int len)
//            {
//                if (n == null)
//                {
//                    mx = Math.Max(mx, len - 1);
//                    return;
//                }
//                dfs(n.left, len + 1);
//                dfs(n.right, len + 1);
//            }
//            public int MaxDepth(TreeNode root)
//            {
//                dfs(root, 1);
//                return mx;
//            }
//        }
//    }
//}
