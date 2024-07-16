public class Solution {
    public int ArrayPairSum(int[] nums) {
        nums = nums.OrderBy(x => x).ToArray();
        int max = 0, i = 0, j = 1;
        while (i < nums.Length) {
            max = max + Math.Min(nums[i], nums[j]);
            i += 2;
            j += 2;
        }
        return max;
    }
}