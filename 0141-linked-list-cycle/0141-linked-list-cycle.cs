/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> nodes = new HashSet<ListNode>();
        while (head != null) {
            if (nodes.Contains(head))
                return true;
            nodes.Add(head);
            head = head.next;
        }
        
        return false;
    }
}