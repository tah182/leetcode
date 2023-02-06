public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        int sum = 0;
        List<bool> answers = new List<bool>();
        foreach (var num in nums) {
            sum = (sum * 2 + num) % 5;
            answers.Add(sum == 0);
        }
        return answers;
    }
}