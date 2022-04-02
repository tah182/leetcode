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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head.next == null && n == 1)
            return null;
        
        Traverse(head, head.next, n, ref head);
        
        return head;
    }
    
    public int Traverse(ListNode prev, ListNode current, int n, ref ListNode head) {
        //Console.WriteLine($"headVal[{head.val}]-prevVal[{prev.val}]-nodeVal:[{current.val}]");
        
        var nthToLast = 1;
        if (current.next != null) {
            nthToLast = Traverse(current, current.next, n, ref head) + 1;
            
            if (nthToLast == n) {
                prev.next = current.next;
                //Console.WriteLine($"is {n}th last, removing");
            } else if (head == prev && nthToLast + 1 == n) {
                //Console.WriteLine($"removing head...");
                head = current;   
            }
        } else if (n == 1) {
            //Console.WriteLine($"lastnode: removing...");
            prev.next = null;
        } else if (head == prev) {
            //Console.WriteLine($"removing head...");
            head = current;
        }
        
        //Console.WriteLine($"[{current.val}] is {nthToLast}th last");
        return nthToLast;
    }
}