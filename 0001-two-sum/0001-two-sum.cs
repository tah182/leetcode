public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numAndIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (numAndIndex.TryGetValue(target - nums[i], out int ans))
                return new int[] { ans, i };
            
            numAndIndex[nums[i]] = i;
        }
        
        return new int[] { -1, -1 };
    }
}