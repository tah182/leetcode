public class Solution {
    public int Search(int[] nums, int target) {
        return Search(nums, target, 0, nums.Length - 1);
    }
    
    public int Search(int[] nums, int target, int left, int right) {
        int mid = ((right - left) / 2) + left;
        if (nums[mid] == target)
            return mid;
        
        if (target < nums[mid])
            right = mid - 1;
        else 
            left = mid + 1;
        
        if (left > right)
            return -1;
        
        return Search(nums, target, left, right);
    }
}