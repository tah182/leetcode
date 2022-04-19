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
    public void RecoverTree(TreeNode root) 
    {
        TreeNode prevNode = null, toSwap = null;
        
        Traverse(root, ref prevNode, ref toSwap);
        
        //handle edge case where the node to swap with 
        //is the last one in the in-order traversal
        if (prevNode != null && toSwap != null)
        {
            Swap(prevNode, toSwap);
        }
    }
    
    private void Traverse(TreeNode root, ref TreeNode prevNode, ref TreeNode toSwap)
    {
        if (root.left != null)
        {
            Traverse(root.left, ref prevNode, ref toSwap);
        }
        
        //in-order work
        if (toSwap == null)
        {
            //we have found the 1st out of place node
            //since the prevNode value should always be smaller
            if (prevNode != null && prevNode.val > root.val)
            {
                toSwap = prevNode;
            }
        }
        else
        {
            //we have found the 2nd out of place node
            //since the 1st out of place node needs to go before the current node
            if (root.val > toSwap.val)
            {
                Swap(prevNode, toSwap);
                prevNode = null;
                toSwap = null;
            }
        }
        
        //advance prevNode pointer
        prevNode = root;
              
        if (root.right != null)
        {
            Traverse(root.right, ref prevNode, ref toSwap);
        }
    }
    
    private void Swap(TreeNode a, TreeNode b)
    {
        //just swap values to maintain the current structure of the tree
        var t = a.val;
        a.val = b.val;
        b.val = t;        
    }
}