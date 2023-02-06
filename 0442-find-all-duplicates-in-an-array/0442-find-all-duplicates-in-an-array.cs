public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> duplicates = new List<int>();
        HashSet<int> map = new HashSet<int>();
        foreach (var num in nums) {
            if (map.Contains(num))
                duplicates.Add(num);
            map.Add(num);
        }
        return duplicates;
    }
}