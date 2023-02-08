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
        var originalCopy = FindTarget(ref original, ref target, false);
        return FindTarget(ref cloned, ref originalCopy, true);
    }
    
    public TreeNode FindTarget(ref TreeNode tree, ref TreeNode target, bool byValue) {
        if (tree == null) return null;
        
        if (!byValue && tree == target)
            return tree;
        
        if (byValue && tree.val == target.val && tree.left?.val == target.left?.val && tree.right?.val == target.right?.val)
            return tree;
        
        return FindTarget(ref tree.left, ref target, byValue) ?? FindTarget(ref tree.right, ref target, byValue);
    }
}