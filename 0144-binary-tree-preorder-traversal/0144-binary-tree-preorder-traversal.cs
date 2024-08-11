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
    private IList<int> traversed = new List<int>();

    public IList<int> PreorderTraversal(TreeNode root) {
        traverse(root);
        return traversed;

    }

    public void traverse(TreeNode current) {
        if (current == null)
            return;
        
        traversed.Add(current.val);
        traverse(current.left);
        traverse(current.right);
    }
}