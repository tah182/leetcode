public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>(); // num, index
        for (int i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(target - nums[i]))
                return new int[] { map[target - nums[i]], i };
            
            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }
        
        return null;
    }
}