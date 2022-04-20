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
public class BSTIterator {
    LinkedList<int> inOrder;
    public BSTIterator(TreeNode root) {
        inOrder = new LinkedList<int>();
        InOrderTraverse(root);
    }
    
    public int Next() {
        int val = inOrder.First.Value;
        inOrder.RemoveFirst();
        return val;
    }
    
    public bool HasNext() {
        return inOrder.Count > 0;
    }
    
    private void InOrderTraverse(TreeNode node) {
        if (node == null)
            return;
        
        InOrderTraverse(node.left);
        inOrder.AddLast(node.val);
        InOrderTraverse(node.right);
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */