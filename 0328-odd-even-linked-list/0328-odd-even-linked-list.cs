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
    public ListNode OddEvenList(ListNode head) {
        if (head == null) return null;

        ListNode odd = head, even = head.next, evenHead = even;

        while (even != null && even.next != null) {
            odd.next = even.next;
            odd = odd.next;
            even.next = even.next.next;
            even = even.next;
        }
        odd.next = evenHead;
        return head;
    }

    private void shiftNodes(ListNode left, ListNode right) {
        ListNode temp = left.next;
        left.next = right;
        temp.next = right.next;
        right.next = temp;
    }
}

/**
1, 2, 3, 4, 5
-  - 
-     -
1, 3, 2, 4, 5
   -     - 
   -        -
1, 3, 5, 2, 4
**/