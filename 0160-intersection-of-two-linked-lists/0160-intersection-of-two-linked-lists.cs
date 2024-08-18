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
        var hash = new HashSet<ListNode>();
        while (headA != null) {
            hash.Add(headA);
            headA = headA.next;
        }

        while (headB != null) {
            if (hash.TryGetValue(headB, out _))
                return headB;
            
            hash.Add(headB);
            headB = headB.next;
        }

        return null;
    }
}