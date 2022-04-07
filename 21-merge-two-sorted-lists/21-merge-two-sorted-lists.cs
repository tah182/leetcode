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
        return MergeLists(list1, list2);
    }
    
    public ListNode MergeLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null)
            return null;
        
        var returnNode = new ListNode();
        
        if (list1 == null) {
            returnNode.val = list2.val;
            list2 = list2.next;
        } else if (list2 == null) {
            returnNode.val = list1.val;
            list1 = list1.next;
        } else {
            if (list1.val < list2.val) {
                returnNode.val = list1.val;
                list1 = list1.next;
            } else {
                returnNode.val = list2.val;
                list2 = list2.next;
            }
        }
        
        returnNode.next = MergeLists(list1, list2);
        return returnNode;
    }
}