/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (original == target)
            return cloned;
        
        if (original.left != null) {
            var val = GetTargetCopy(original.left, cloned.left, target);
            if (val != null)
                return val;
        }
        if (original.right != null) {
            var val = GetTargetCopy(original.right, cloned.right, target);
            if (val != null)
                return val;
        }
        
        return null;
    }
}