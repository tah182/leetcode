public class Solution {
    public int Jump(int[] nums) {
        int jumps = 0;
        int slow = 0, fast = 0;
        for (int i = 0; i < nums.Length - 1; ++i) {
            Console.WriteLine($"i[{i}] & fast[{fast}] nums[i]={nums[i]}");
            fast = Math.Max(fast, i + nums[i]);
            
            if (i == slow) {
                jumps++;
                slow = fast;
            }
        }
        return jumps;
    }
}