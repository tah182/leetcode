public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int cursor = 0;
        foreach(var i in nums) {
            if (i != val) {
                nums[cursor] = i;
                cursor++;
            }
        }
        return cursor;
    }
}