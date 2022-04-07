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
        ListNode next = null;
        if (lists.Length == 0)
            return null;
        
        foreach (var node in lists) {
            if (node != null)
                priority.Enqueue(node, node.val);
        }
        
        while (priority.Count > 0) {
            //Console.WriteLine($"[{string.Join(",", priority.UnorderedItems)}]");
            var temp = priority.Dequeue();
            //Console.WriteLine($"temp[{temp.val}]");
            if (head == null)
                head = temp;
            else if (next == null) {
                next = temp;
                head.next = next;
            } else {
                next.next = temp;
                next = next.next;
            }
            
            //Console.WriteLine($"next = {next}[{next?.val}]");
            if (temp.next != null)
                priority.Enqueue(temp.next, temp.next.val);
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