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
    public TreeNode IncreasingBST(TreeNode root) {
        TreeNode currentNode = null;
        foreach (int num in IncreasingNum(root)) {
            if (currentNode == null) {
                root = new TreeNode(num);
                currentNode = root;
            } else {
                currentNode.right = new TreeNode(num);
                currentNode = currentNode.right;
            }
        }
        return root;
    }
    
    public IList<int> IncreasingNum(TreeNode root) {
        List<int> nums = new List<int>();
        if (root == null)
            return nums;
        
        nums.AddRange(IncreasingNum(root.left));
        nums.Add(root.val);
        nums.AddRange(IncreasingNum(root.right));
        return nums;
    }
}