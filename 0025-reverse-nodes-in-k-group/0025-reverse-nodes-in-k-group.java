/**
 * Definition for singly-linked list.
 * public class ListNode {
 * int val;
 * ListNode next;
 * ListNode() {}
 * ListNode(int val) { this.val = val; }
 * ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

class Solution {
    /**
     * Reverses the nodes of a linked list k at a time.
     * If the number of nodes is not a multiple of k,
     * then the left-out nodes at the end should remain as they are.
     *
     * @param head The head of the linked list.
     * @param k The group size.
     * @return The head of the modified list.
     */
    public ListNode reverseKGroup(ListNode head, int k) {
        // Base case: if the list is empty, or k is 1, no reversal is needed.
        if (head == null || k == 1) {
            return head;
        }

        // Create a dummy node to simplify handling the new head of the list.
        // This dummy node points to the original head.
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        // 'prev' will point to the node just before the current k-group being reversed.
        // Initially, it points to the dummy node.
        ListNode prev = dummy;

        // 'current' will iterate through the list to find the start of each k-group.
        // It starts at the dummy node.
        ListNode current = dummy;

        // First, count the total number of nodes in the list.
        // This helps determine how many full k-groups can be reversed.
        int count = 0;
        while (current.next != null) {
            current = current.next;
            count++;
        }

        // Reset 'current' to 'dummy' for the main reversal loop.
        current = dummy;

        // Loop as long as there are at least 'k' nodes remaining to form a full group.
        while (count >= k) {
            // 'currHeadOfGroup' is the first node of the current k-group to be reversed.
            // It's the node immediately after 'prev'.
            ListNode currHeadOfGroup = prev.next;

            // 'nextGroupStart' will be the node that comes immediately after the
            // k-group once it's reversed. This is found by advancing 'currHeadOfGroup' k-1 times.
            ListNode nextGroupStart = currHeadOfGroup;
            for (int i = 0; i < k; i++) {
                if (nextGroupStart == null) {
                    // This should not happen if count >= k, but as a safeguard.
                    break;
                }
                nextGroupStart = nextGroupStart.next;
            }


            // These three pointers are used for reversing the current k-group:
            // - 'nodePrev': points to the previously reversed node.
            // - 'nodeCurr': points to the current node being processed.
            // - 'nodeNext': temporarily stores the next node before 'nodeCurr.next' is changed.
            ListNode nodePrev = nextGroupStart; // The last node of the reversed group will point to 'nextGroupStart'
            ListNode nodeCurr = currHeadOfGroup;
            ListNode nodeNext = null;

            // Reverse the k nodes within the current group.
            // This is a standard linked list reversal process for 'k' nodes.
            for (int i = 0; i < k; i++) {
                nodeNext = nodeCurr.next; // Store the next node
                nodeCurr.next = nodePrev; // Reverse the current node's pointer
                nodePrev = nodeCurr;      // Move 'nodePrev' to the current node
                nodeCurr = nodeNext;      // Move 'nodeCurr' to the next node
            }

            // After reversing the k nodes:
            // 1. The 'prev' node (before the group) should point to the new head of the reversed group.
            //    The new head of the reversed group is 'nodePrev' (which holds the original k-th node).
            // 2. The original head of the group ('currHeadOfGroup') is now the tail of the reversed group.
            //    Its 'next' pointer should point to the 'nextGroupStart' (the node after the original k-group).
            prev.next = nodePrev;
            currHeadOfGroup.next = nextGroupStart;

            // Update 'prev' to be the original head of the group. This is because
            // this node is now the tail of the newly reversed group, and will serve
            // as the 'prev' for the *next* k-group.
            prev = currHeadOfGroup;

            // Decrease the count by k as we have processed one k-group.
            count -= k;
        }

        // The head of the modified list is the node after the dummy node.
        return dummy.next;
    }
}
