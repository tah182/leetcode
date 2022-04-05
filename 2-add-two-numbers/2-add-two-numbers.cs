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
        List<int> sum = SumTwoLists(l1, l2, 0);
        Console.WriteLine($"{string.Join("", sum)}");
        
        ListNode head = new ListNode { val = sum[0] };
        var current = head;
        for (int i = 1; i < sum.Count; i++) {
            //Console.WriteLine($"pushing val:{charArray[i]} onto Node val: {current.val}");
            current.next = new ListNode { val = sum[i] };
            current = current.next;
        }
        return head;
    }
    
    public List<int> SumTwoLists(ListNode l1, ListNode l2, int carryOver) {
        int sum = ((l1?.val ?? 0) + (l2?.val ?? 0)) + carryOver;
        List<int> nums = new List<int> { (sum > 9 ? sum-10 : sum) };
        
        if (l1?.next == null && l2?.next == null) {
            if (sum > 9)
                nums.Add(1);
        }
        
        if (l1?.next != null && l2?.next != null) 
            nums.AddRange(SumTwoLists(l1.next, l2.next, sum / 10));
        else if (l2?.next != null)
            nums.AddRange(SumTwoLists(null, l2.next, sum / 10));
        else if (l1?.next != null)
            nums.AddRange(SumTwoLists(l1.next, null, sum / 10));
        
        return nums;
    }
}