public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var num1Map = new Dictionary<int, int>();   // num and count
        foreach (var num in nums1) {
            if (num1Map.ContainsKey(num))
                num1Map[num]++;
            else
                num1Map.Add(num, 1);
        }
        
        var result = new List<int>();
        foreach (var num in nums2) {
            if (num1Map.ContainsKey(num)) {
                result.Add(num);
                if (num1Map[num] == 1)
                    num1Map.Remove(num);
                else
                    num1Map[num]--;
            }
        }
        
        return result.ToArray();
    }
}