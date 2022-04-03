/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        List<int> values = new List<int>();
        if (root == null)
            return values;
        
        values.Add(root.val);
        foreach (var child in root.children) {
            values.AddRange(Preorder(child));
        }
        //Console.WriteLine($"added: [{string.Join(",", values)}]");
        return values;
    }
    
}