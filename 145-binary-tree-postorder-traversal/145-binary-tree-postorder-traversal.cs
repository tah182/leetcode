/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> nums = new List<int>();
        if (root == null)
            return nums;
        
        if (root.left != null)
            nums.AddRange(PostorderTraversal(root.left));
        if (root.right != null)
            nums.AddRange(PostorderTraversal(root.right));
        
        nums.Add(root.val);
        return nums;
    }
}