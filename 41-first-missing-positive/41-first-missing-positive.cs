public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
        var smallestMissing = 1;
        foreach(var num in nums.Where(n => n > 0)) {
            if (num == smallestMissing)
                smallestMissing++;
        }
        return smallestMissing;
    }
}