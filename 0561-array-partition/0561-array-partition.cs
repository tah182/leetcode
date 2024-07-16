public class Solution {
    public int ArrayPairSum(int[] nums) {
        nums = nums.OrderBy(x => x).ToArray();
        int max = 0;
        for (int i = 0; i < nums.Length - 1; i +=2) {
            max = max + Math.Min(nums[i], nums[i + 1]);
        }
        return max;
    }
}