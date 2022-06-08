public class Solution {
    public int[] SortedSquares(int[] nums) {
        return nums.Select(n => n * n).OrderBy(n => n).ToArray();
    }
}