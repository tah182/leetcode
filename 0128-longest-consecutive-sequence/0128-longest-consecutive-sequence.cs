public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>();
        foreach (var num in nums) {
            if (!set.Contains(num))
                set.Add(num);
        }
        
        var longest = 0;
        foreach (var num in nums) {
            if (!set.Contains(num - 1)) {
                var length = 0;
                while (set.Contains(num + length))
                    length++;
                longest = Math.Max(length, longest);
            }
        }
        
        return longest;
    }
}