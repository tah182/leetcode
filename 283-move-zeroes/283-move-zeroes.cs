public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp;
        for (int lastNonZero = 0, cur = 0; cur < nums.Length; cur++) {
            if (nums[cur] != 0) {
                temp = nums[cur];
                nums[cur] = nums[lastNonZero];
                nums[lastNonZero++] = temp;
            }
        }
    }
}