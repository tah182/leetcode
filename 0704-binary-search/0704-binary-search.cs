public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1, mid;
        while (left <= right) {
            mid = (right - left) / 2 + left;
            
            if (target < nums[mid])
                right = mid - 1;
            else if (target > nums[mid])
                left = mid + 1;
            else
                return mid;
        }
        
        return -1;
    }
}