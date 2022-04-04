/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SwapNodes(ListNode head, int k) {
        var current = head;
        List<ListNode> nodes = new List<ListNode>();
        while (current.next != null) {
            nodes.Add(current);
            current = current.next;
        }
        nodes.Add(current);
        
        var temp = nodes[k - 1].val;
        nodes[k - 1].val = nodes[nodes.Count - k].val;
        nodes[nodes.Count - k].val = temp;
        
//         var kthStart = KthFromBeginning(head, 1, k);
//         var kthEnd = KthFromEnd(head, k);
//         //Console.WriteLine($"k[{k}]th from beginning Val = {kthStart.val}");
//         //Console.WriteLine($"k[{k}]th from end Val = {kthEnd.val}");
        
//         var temp = kthStart.val;
//         kthStart.val = kthEnd.val;
//         kthEnd.val = temp;
        
        return head;
    }
    
//     public ListNode KthFromBeginning(ListNode current, int currentDepth, int k) {
//         if (currentDepth == k)
//             return current;
        
//         return KthFromBeginning(current.next, ++currentDepth, k);
//     }
    
//     public ListNode KthFromEnd(ListNode current, int k) {
//         List<ListNode> nodes = new List<ListNode>();
//         while (current.next != null) {
//             nodes.Add(current);
//             current = current.next;
//         }
//         nodes.Add(current);
        
//         //Console.WriteLine($"fullnode list: [{string.Join(",", nodes.Select(n => n.val))}]");
//         return nodes[nodes.Count - k];
//     }
}