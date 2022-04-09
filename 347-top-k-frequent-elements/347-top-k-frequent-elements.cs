public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            if (counts.ContainsKey(nums[i])) {
                counts[nums[i]] += 1;
            } else
                counts.Add(nums[i], 1);
        }
        
//         foreach (var map in counts.OrderByDescending(c => c.Value)) {
//             Console.WriteLine($"[{map.Key}]->{map.Value}");
//         }
        
        return counts.OrderByDescending(c => c.Value).Take(k)
                     .Select(c => c.Key)
                     .ToArray();
    }
}