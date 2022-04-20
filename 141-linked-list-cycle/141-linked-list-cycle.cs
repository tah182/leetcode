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
        HashSet<ListNode> map = new HashSet<ListNode>();
        
        while (head != null) {
            if (map.Contains(head))
                return true;
            map.Add(head);
            head = head.next;
        }
        
        return false;
    }
}