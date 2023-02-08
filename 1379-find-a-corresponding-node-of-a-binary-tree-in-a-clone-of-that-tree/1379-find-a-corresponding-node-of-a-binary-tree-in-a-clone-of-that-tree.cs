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
        var originalCopy = FindTarget(original, target, false);
        Console.WriteLine($"{(originalCopy == null ? "not found" : "found")}");
        return FindTarget(cloned, originalCopy, true);
    }
    
    public TreeNode FindTarget(TreeNode tree, TreeNode target, bool byValue) {
        if (tree == null) return null;
        
        if (!byValue && tree == target)
            return tree;
        
        if (byValue && tree.val == target.val && tree.left?.val == target.left?.val && tree.right?.val == target.right?.val)
            return tree;
        
        return FindTarget(tree.left, target, byValue) ?? FindTarget(tree.right, target, byValue);
    }
}