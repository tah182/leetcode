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
    public ListNode DeleteMiddle(ListNode head) {
        if (head == null || head.next == null)
            return null;
        
        List<ListNode> nodes = new List<ListNode>();
        var current = head;
        while (current != null) {
            nodes.Add(current);
            current = current.next;
        }
        
        nodes[(nodes.Count / 2) - 1].next = nodes[(nodes.Count / 2)].next;
        return head;
    }
}