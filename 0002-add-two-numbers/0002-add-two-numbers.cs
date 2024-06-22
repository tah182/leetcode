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
        var result = new ListNode();
        var current = result;
        
        var carry = 0;
        while (l1 != null || l2 != null || carry == 1) {
            var sum = 0;
            if (l1 != null) {
                sum += l1.val;
                l1 = l1.next;
            } 
            
            if (l2 != null) {
                sum += l2.val;
                l2 = l2.next;
            } 
            
            sum += carry;
            current.val = sum % 10;
            carry = sum / 10;
            
            if (l1 != null || l2 != null || carry == 1) {
                current.next = new ListNode();
                current = current.next;
            }
        } 
        
        return result;
    }
}