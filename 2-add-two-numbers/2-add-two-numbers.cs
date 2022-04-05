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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = SumTwoLists(l1, l2, 0);
        //Console.WriteLine($"{string.Join("", sum)}");
        
//         ListNode head = new ListNode { val = sum[0] };
//         var current = head;
//         for (int i = 1; i < sum.Count; i++) {
//             //Console.WriteLine($"pushing val:{charArray[i]} onto Node val: {current.val}");
//             current.next = new ListNode { val = sum[i] };
//             current = current.next;
//         }
        return head;
    }
    
    public ListNode SumTwoLists(ListNode l1, ListNode l2, int carryOver) {
        int sum = ((l1?.val ?? 0) + (l2?.val ?? 0)) + carryOver;
    
        ListNode head = new ListNode();
        head.val = sum > 9 ? sum - 10 : sum;
        
        if (l1?.next == null && l2?.next == null && sum > 9) {
            head.next = new ListNode { val = 1};
        }
        
        if (l1?.next != null && l2?.next != null) 
            head.next = SumTwoLists(l1.next, l2.next, sum / 10);
        else if (l2?.next != null)
            head.next = SumTwoLists(null, l2.next, sum / 10);
        else if (l1?.next != null)
            head.next = SumTwoLists(l1.next, null, sum / 10);
        
        return head;
    }
}