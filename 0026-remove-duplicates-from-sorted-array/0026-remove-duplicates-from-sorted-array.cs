public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) return nums.Length;

        int left = 0, right = 1;
        while (right < nums.Length) {
            if (nums[left] == nums[right])
                right++;
            else {
                nums[left + 1] = nums[right];
                left++;
                right++;
            }
        }
        return left + 1;
    }
}