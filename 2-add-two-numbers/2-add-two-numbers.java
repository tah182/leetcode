/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode finalList = new ListNode();
        ListNode current = finalList;
        var carry = 0;
        while (l1 != null || l2 != null) {
            if (l1 != null && l2 != null) {
                current.val = carry + l1.val + l2.val;
                l1 = l1.next;
                l2 = l2.next;
            } else if (l1 == null) {
                current.val = carry + l2.val;
                l2 = l2.next;
            } else {
                current.val = carry + l1.val;
                l1 = l1.next;
            }
            
            if (current.val > 9)
            {
                current.val -= 10;
                carry = 1;
            } else
                carry = 0;
            
            if (l1 != null || l2 != null) {
                current.next = new ListNode();
                current = current.next;   
            } else if (carry == 1)
                current.next = new ListNode(carry);
        }
        return finalList;
    }
}