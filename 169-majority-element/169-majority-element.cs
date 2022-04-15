public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> finds = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            if (finds.ContainsKey(nums[i])) 
                finds[nums[i]]++;
            else
                finds.Add(nums[i], 1);
        }
        foreach (var keyValue in finds) {
            if (keyValue.Value > nums.Length / 2)
                return keyValue.Key;
        }
        return 0;
    }
}