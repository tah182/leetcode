public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int cursor = 0;
        for(int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[cursor]) {
                nums[cursor + 1] = nums[i];
                cursor++;   
            }
        }
        return cursor + 1;
    }
}