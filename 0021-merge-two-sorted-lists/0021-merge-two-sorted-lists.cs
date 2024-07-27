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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 is null && list2 is null)
            return null;
        
        ListNode head = null;
        var current = head;
        while (list1 is not null || list2 is not null) {
            ListNode next;
            if (list1 is null) {
                if (head == null)
                    head = list2;
                else
                    current.next = list2;
                break;
            }
            if (list2 is null) {
                if (head == null)
                    head = list1;
                else
                    current.next = list1;
                break;
            }

            if (list1.val < list2.val) {
                next = list1;
                list1 = list1.next;
            } else {
                next = list2;
                list2 = list2.next;
            }
            
            if (current == null)
                current = head = next;
            else {
                current.next = next;
                current = current.next;
            }
        }
        return head;
    }
}