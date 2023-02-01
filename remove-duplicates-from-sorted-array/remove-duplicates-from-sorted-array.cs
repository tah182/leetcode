public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var cursor = 0;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[cursor]) {
                cursor++;
                nums[cursor] = nums[i];
            }
        }
        return ++cursor;
    }
}