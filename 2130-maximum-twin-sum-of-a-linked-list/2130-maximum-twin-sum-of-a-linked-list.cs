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
    public int PairSum(ListNode head) {
        if (head == null) return 0;
        
        Dictionary<int, int> twins = new Dictionary<int, int>();
        int size = 0;
        while (head != null) {
            twins[size] = head.val;
            size++;
            head = head.next;            
        }
        
        int max = int.MinValue;
        foreach (var keyval in twins) {
            var sum = keyval.Value + twins[size - 1 - keyval.Key];
            max = Math.Max(max, sum);
        }
        
        return max;
    }
}