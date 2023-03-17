public class Solution {
    public int ThirdMax(int[] nums) {
        var unique = new HashSet<int>();
        var pq = new PriorityQueue<int, int>();
        foreach (var num in nums) {
            if (!unique.Contains(num)) {
                unique.Add(num);
                pq.Enqueue(num, num);
                
                if (pq.Count > 3)
                    pq.Dequeue();
            }
        }
        
        if (pq.Count < 3) {
            while (pq.Count > 1)
                pq.Dequeue();
        }
        
        return pq.Peek();
    }
}