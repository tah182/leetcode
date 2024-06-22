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
        do {
            if (l1 == null && l2 != null) {
                current.val = addNumbers(l2.val, carry, out carry);
                l2 = l2.next;
            } else if (l2 == null && l1 != null) {
                current.val = addNumbers(l1.val, carry, out carry);
                l1 = l1.next;
            } else if (l2 != null && l1 != null) {
                current.val = addNumbers(l1.val + carry, l2.val, out carry);
                l1 = l1.next;
                l2 = l2.next;
            } else if (carry == 1) {
                current.val = carry;   
                carry = 0;
            }
            
            if (l1 != null || l2 != null || carry == 1)
            {
                current.next = new ListNode();
                current = current.next;
            }
        } while (l1 != null || l2 != null || carry == 1);
        
        return result;
    }
    
    private int addNumbers(int i, int k, out int carry) {
        var result = i + k;
        
        if (result > 9) { 
            carry = 1;
            return result - 10;
        }
        
        carry = 0;
        return result;
    }
}