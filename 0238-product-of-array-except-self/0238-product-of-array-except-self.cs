public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
        output[0] = 1;
        for (int i = 1; i < nums.Length; i++) {
            output[i] = nums[i - 1] * output[i - 1];
        }

        int r = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            output[i] = output[i] * r;
            r = r * nums[i];
        }

        return output;
    }
}