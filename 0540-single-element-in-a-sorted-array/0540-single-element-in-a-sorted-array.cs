public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while (l < r) {
            int m = (l + r) / 2;
            if ((m == 0 && nums[m] != nums[m + 1])
                || (m == nums.Length - 1 && nums[m] != nums[m - 1]))
                return nums[m];
            
            if (nums[m] == nums[m + 1]) {
                if (m % 2 == 0) l = m + 2;
                else r = m - 1;
            } else {
                if (nums[m] != nums[m - 1]) return nums[m];
                
                if (m % 2 == 0) r = m - 2;
                else l = m + 1;
            }
        }
        return nums[l];
    }
}