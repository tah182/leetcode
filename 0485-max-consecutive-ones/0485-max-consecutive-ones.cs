public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var counter = 0;
        foreach (var num in nums) {
            if (num == 0)
            {
                max = Math.Max(counter, max);
                counter = 0;
            } else
                counter++;
        }
        
        return Math.Max(counter, max);
    }
}