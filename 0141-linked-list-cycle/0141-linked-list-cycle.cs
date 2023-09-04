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
        if (head == null) return false;
        
        var fast = head;
        var slow = head;
        
        do {
            slow = slow.next;
            fast = fast.next;
            if (fast != null) 
                fast = fast.next;
        } while (fast != null && fast != slow);
        
        return (fast != null && fast == slow);
    }
}