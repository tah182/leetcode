public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        if (nums.Length <= 1)
            return nums;
        
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] % 2 != 0) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[j] % 2 == 0)
                    {
                        var temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        j = nums.Length;
                    }
                }
            }
        }
        return nums;
    }
}