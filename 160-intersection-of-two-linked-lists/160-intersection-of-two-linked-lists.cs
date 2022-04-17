/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int aLength = 0;
        int bLength = 0;
        
        var currentA = headA;
        var currentB = headB;
        
        while (currentA != null) {
            aLength++;
            currentA = currentA.next;
        }
        
        while (currentB != null) {
            bLength++;
            currentB = currentB.next;
        }
        
        while (aLength - bLength > 0) {
            headA = headA.next;
            aLength--;
        }
        
        while (bLength - aLength > 0) {
            headB = headB.next;
            bLength--;
        }
        
        while (headA != headB) {
            headA = headA.next;
            headB = headB.next;
        }
        return headA;
    }
}