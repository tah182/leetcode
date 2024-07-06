public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (dic.TryGetValue(num, out _)) {
                dic[num]++;
                if (dic[num] > nums.Count() / 2)
                    return num;
            }
            else
                dic.Add(num, 1);
        }
        return nums[0];
    }
}