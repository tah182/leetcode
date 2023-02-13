public class Solution {
    public int MinMaxGame(int[] nums) {
        var n = nums.Length;
        while (n > 1) {
            for (int i = 0; i < n / 2; i++) {
                if (i % 2 == 0)
                    nums[i] = Math.Min(nums[2 * i + 1], nums[2 * i]);
                else
                    nums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
            }
            n = n / 2;
        }
        
        return nums[0];
    }
}