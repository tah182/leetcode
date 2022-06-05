public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;
        int mid;
        while (left <= right) {
            mid = (right - left) / 2 + left;
            // Console.WriteLine($"mid: {mid}");
            if (target == nums[mid])
                return mid;
            if (target > nums[mid])
                left = mid + 1;
            else 
                right = mid - 1;
        }
       
       return -1;
    }
}