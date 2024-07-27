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
        
        var returnNode = list1;
        
        if (list1 == null) {
            returnNode = list2;
            list2 = list2.next;
        } else if (list2 == null) {
            list1 = list1.next;
        } else {
            if (list1.val < list2.val) {
                list1 = list1.next;
            } else {
                returnNode = list2;
                list2 = list2.next;
            }
        }
        
        returnNode.next = MergeTwoLists(list1, list2);
        return returnNode;
    }
}