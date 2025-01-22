using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo.leetcode
{
    internal class lc_543
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            static int mx = -1;
            TreeNode farest = null;
            Dictionary<TreeNode, TreeNode> curToPrev = new
                            Dictionary<TreeNode, TreeNode>();
            void dfs(TreeNode cur, int len)
            {
                // dfs from root to V
                // dfs from V to G
                if (cur.left != null)
                {
                    curToPrev.Add(cur.left, cur);
                    dfs(cur.left, len + 1);
                }
                if (cur.right != null)
                {
                    curToPrev.Add(cur.right, cur);
                    dfs(cur.right, len + 1);
                }
                if (mx < len)
                {
                    mx = len;
                    farest = cur;
                }
            }
            
            static int toLeaf(TreeNode cur)
            {
                if (cur == null)
                    return -1;
                mx = Math.Max(mx, toLeaf(cur.left)+toLeaf(cur.right)+2);
                return int.Max(toLeaf(cur.left), toLeaf(cur.right)) + 1;
            }
            public static int DiameterOfBinaryTree(TreeNode root)
            {
                Console.WriteLine(toLeaf(root));
                return 0;
            }
        }
    }
}
