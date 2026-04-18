# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def subtree_size(self, root: Optional[TreeNode]):
        if root is None:
            return 0

        lsize = self.subtree_size(root.left)
        rsize = self.subtree_size(root.right)
        return 1 + lsize + rsize


    def kthSmallest(self, root: Optional[TreeNode], k: int) -> int:
        
        smaller_cnt = self.subtree_size(root.left)
        if smaller_cnt + 1 == k:
            return root.val
        elif smaller_cnt >= k:
            return self.kthSmallest(root.left, k)
        else:
            return self.kthSmallest(root.right, k - smaller_cnt - 1) 
        