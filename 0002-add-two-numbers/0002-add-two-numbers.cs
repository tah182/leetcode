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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        
        // just do first to create the listNode
        ListNode head = new ListNode();
        if (l1.val + l2.val > 9) {
            carry = 1;
            head.val = l1.val + l2.val - 10;
        } else
            head.val = l1.val + l2.val;
        
        var current = head;
        l1 = l1.next; l2 = l2.next;
        while (l1 != null || l2 != null) {
            var val = 0;
            if (l1 == null) {
                val = l2.val + carry;
                l2 = l2.next;
            } else if (l2 == null) {
                val = l1.val + carry;
                l1 = l1.next;
            } else {
                val = l1.val + l2.val + carry;
                l1 = l1.next;
                l2 = l2.next;
            }
            
            if (val > 9) {
                val -= 10;
                carry = 1;
            } else
                carry = 0;
            
            current.next = new ListNode(val);
            current = current.next;
        }
        
        if (carry > 0) 
            current.next = new ListNode(1);
        
        return head;
    }
}