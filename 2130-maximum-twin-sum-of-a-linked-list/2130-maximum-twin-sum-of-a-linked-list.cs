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
        var values = new List<int>();
        
        while (head != null) {
            values.Add(head.val);
            head = head.next;
        }
        
        int i = 0, j = values.Count() - 1, max = 0;
        while (i < j) {
            max = Math.Max(max, values[i] + values[j]);
            i++;
            j--;
        }
        
        return max;
    }
}