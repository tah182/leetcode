public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hash = new HashSet<int>();
        foreach (var num in nums) {
            if (!hash.Add(num))
                return true;
        }

        return false;
    }
}