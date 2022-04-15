public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> finds = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (finds.ContainsKey(num)) 
                finds[num]++;
            else
                finds.Add(num, 1);
        }
        foreach (var keyValue in finds) {
            if (keyValue.Value > nums.Length / 2)
                return keyValue.Key;
        }
        return 0;
    }
}