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
    public ListNode MergeKLists(ListNode[] lists) {
        var leastNodeListIndex = -1;
        ListNode leastNode = null;
        for(var i = 0; i < lists.Length; i++) {
            if (lists[i] == null)
                continue;
            
            if (leastNode == null || lists[i].val < leastNode.val)
            {
                leastNode = lists[i];
                leastNodeListIndex = i;
            }
        }
        
        if (leastNodeListIndex == -1)
            return leastNode;
        
        lists[leastNodeListIndex] = lists[leastNodeListIndex].next;
        leastNode.next = MergeKLists(lists);
        return leastNode;
    }
}