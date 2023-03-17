public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var cache = new PriorityQueue<int, int>();
        foreach (var num in nums) {
            cache.Enqueue(num, num);
            if (cache.Count > k)
                cache.Dequeue();
        }
        
        return cache.Peek();
    }
}