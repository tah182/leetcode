public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            var mod = (right - left) / 2 + left;
            if (target == nums[mod])
                return mod;
            
            if (target < nums[mod])
                right = mod - 1;
            else
                left = mod + 1;
        }
        
        return -1;
    }
}