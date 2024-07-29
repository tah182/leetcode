public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2) return nums.Length;

        int left = 0;
        for (int right = 0; right < nums.Length; right++) {
            if (nums[left] != nums[right]) {
                nums[left + 1] = nums[right];
                left++;
            }
        }
        return left + 1;
    }
}