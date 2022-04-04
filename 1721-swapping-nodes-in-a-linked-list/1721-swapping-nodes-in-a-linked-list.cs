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
        List<ListNode> nodes = new List<ListNode>();
        for (var current = head; current != null; current = current.next) {
            nodes.Add(current);
        }
        
        var temp = nodes[k - 1].val;
        nodes[k - 1].val = nodes[nodes.Count - k].val;
        nodes[nodes.Count - k].val = temp;
        
        return head;
    }
}