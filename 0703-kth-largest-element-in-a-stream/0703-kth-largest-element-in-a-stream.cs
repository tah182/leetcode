public class KthLargest {
    private int capacity;
    private PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
    
    public KthLargest(int k, int[] nums) {
        capacity = k;
        foreach (var num in nums)
            Add(num);
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        while (pq.Count > capacity)
            pq.Dequeue();
        
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */