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
    PriorityQueue<ListNode, int> priority = new PriorityQueue<ListNode, int>();
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode head = null;
        ListNode current = null;
        if (lists.Length == 0)
            return null;
        
        foreach (var node in lists) {
            if (node != null)
                priority.Enqueue(node, node.val);
        }
        
        while (priority.Count > 0) {
            if (head == null) {
                head = priority.Dequeue();
                if (head.next != null)
                    priority.Enqueue(head.next, head.next.val);
                
                continue;
            }
            
            if (current == null) {
                current = priority.Dequeue();
                head.next = current;
            } else {
                current.next = priority.Dequeue();
                current = current.next;
            }
            
            if (current.next != null)
                priority.Enqueue(current.next, current.next.val);
        }
        
        return head;
    }
//     public ListNode MergeKLists(ListNode[] lists) {
//         var leastNodeListIndex = -1;
//         ListNode leastNode = null;
//         for(var i = 0; i < lists.Length; i++) {
//             if (lists[i] == null)
//                 continue;
            
//             if (leastNode == null || lists[i].val < leastNode.val)
//             {
//                 leastNode = lists[i];
//                 leastNodeListIndex = i;
//             }
//         }
        
//         if (leastNodeListIndex == -1)
//             return leastNode;
        
//         lists[leastNodeListIndex] = lists[leastNodeListIndex].next;
//         leastNode.next = MergeKLists(lists);
//         return leastNode;
//     }
}