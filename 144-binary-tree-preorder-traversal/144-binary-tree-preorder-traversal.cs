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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> vals = new List<int>();
        if (root == null)
            return vals;
        
        vals.Add(root.val);
        if (root.left != null)
            vals.AddRange(PreorderTraversal(root.left));
        if (root.right != null)
            vals.AddRange(PreorderTraversal(root.right));
        
        return vals;
    }
}