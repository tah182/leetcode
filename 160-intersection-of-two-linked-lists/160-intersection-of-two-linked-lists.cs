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
        while (headA != null) {
            var currentB = headB;
            while (currentB != null) {
                if (headA == currentB)
                    return headA;
                currentB = currentB.next;
            }
            headA = headA.next;
        }
        return null;
    }
}