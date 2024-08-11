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
        if (root == null)
            return [];

        List<int> traversed = new ();
        traversed.Add(root.val);
        traversed.AddRange(PreorderTraversal(root.left));
        traversed.AddRange(PreorderTraversal(root.right));

        return traversed;
    }
}