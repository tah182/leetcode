public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
        var smallestMissing = 1;
        foreach(var num in nums) {
            if (num == smallestMissing)
                smallestMissing++;
        }
        return smallestMissing;
    }
}