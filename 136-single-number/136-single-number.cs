public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> singles = new Dictionary<int, int>();
        foreach(var num in nums) {
            if (singles.ContainsKey(num))
                singles.Remove(num);
            else
                singles.Add(num, 1);
        }
        return singles.FirstOrDefault().Key;
    }
}