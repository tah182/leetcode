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
        ListNode head = null;
        var current = head;
        while (list1 != null || list2 != null) {
            if (list1 == null) {
                if (head == null) return list2;
                
                current.next = list2;
                return head;
            }
            if (list2 == null) {
                if (head == null) return list1;
                
                current.next = list1;
                return head;
            }
                
            if (list1.val <= list2.val) {
                if (current == null) {
                    head = new ListNode(list1.val);
                    current = head;
                } else {
                    current.next = new ListNode(list1.val);
                    current = current.next;
                }
                list1 = list1.next;
            } else {
                if (current == null) {
                    head = new ListNode(list2.val);
                    current = head;
                } else {
                    current.next = new ListNode(list2.val);
                    current = current.next;
                }
                list2 = list2.next;
            }
        }
        
        return head;
    }
}
/**
[1,2,4]
[1,3,4]

head 1
current = head
current 1
[2,4]
[1,3,4]

current
**/