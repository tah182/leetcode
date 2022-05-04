public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int[] snums = (int[])nums.Clone();
        Array.Sort(snums);
        int start = snums.Length, end = 0;
        for (int i = 0; i < snums.Length; i++) {
            if (snums[i] != nums[i]) {
                start = Math.Min(start, i);
                end = Math.Max(end, i);
            }
        }
        return (end - start >= 0 ? end - start + 1 : 0);
    }
}