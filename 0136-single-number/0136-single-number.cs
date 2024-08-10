public class Solution {
    public int SingleNumber(int[] nums) {
        var hash = new HashSet<int>();
        foreach (var num in nums) {
            if (hash.Contains(num))
                hash.Remove(num);
            else
                hash.Add(num);
        }
        return hash.First();
    }
}