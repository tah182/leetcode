public class Solution {
    public void MoveZeroes(int[] nums) {
        int left = 0, right = 1;
        while (right < nums.Length && left < nums.Length) {
            // Console.WriteLine($"current progress: {string.Join(", ", nums)}, left: {nums[left]} right: {nums[right]}");
            if (nums[left] != 0) {
                left++;
                continue;
            }
            if (nums[right] == 0 || right <= left) {
                right++;
                continue;
            }

            if (nums[left] == 0) {
                nums[left] = nums[right];
                nums[right] = 0;
                left++;
                right++;
            }
        }
    }
}