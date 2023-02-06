public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        List<int> solution = new List<int>();
        for (int i = 0; i < n; i++) {
            solution.Add(nums[i]);
            solution.Add(nums[i + n]);
        }
        
        return solution.ToArray();
    }
}