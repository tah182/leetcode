public class KthLargest {
    private int _k;
    private PriorityQueue<int, int> pq;
    
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int, int>();
        
        _k = k;
        foreach (var num in nums) {
            pq.Enqueue(num, num);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        while (pq.Count > _k) {
            pq.Dequeue();
        }
        
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */