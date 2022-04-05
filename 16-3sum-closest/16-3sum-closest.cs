public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        if (nums.Length <= 3)
            return nums[0] + nums[1] + nums[2];
        
        // sort
        Array.Sort(nums);
        var closest = int.MaxValue;
        for (int i = 0; i < nums.Length - 2; i++){
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                if (Math.Abs((double)target - (nums[i] + nums[left] + nums[right])) < Math.Abs((double)target - closest))
                    closest = nums[i] + nums[left] + nums[right];
                
                if (target > nums[i] + nums[left] + nums[right])
                    left++;
                else
                    right--;
            }
        }
        return closest;
    }
}