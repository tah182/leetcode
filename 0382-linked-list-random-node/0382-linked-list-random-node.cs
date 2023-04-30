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
    private ListNode list;
    private int listSize = 0;
    private Random rand;
    
    public Solution(ListNode head) {
        list = head;
        var next = head;
        while (next != null) {
            listSize++;
            next = next.next;
        }
        rand = new Random();
    }
    
    public int GetRandom() {
        var trav = rand.Next(0, listSize);
        var returnNode = list;
        while (trav > 0) {
            returnNode = returnNode.next;
            trav--;
        }

        return returnNode.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */