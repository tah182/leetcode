public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var odds = new Queue<(int index, int value)>();
        int temp = 0;
        (int index, int value) odd;
        for (int i = 0 ; i < nums.Length; i++) {
            if (nums[i] % 2 == 0) {
                if (odds.Count == 0)
                    continue;
                else {
                    odd = odds.Dequeue();
                    // Console.WriteLine($"[{string.Join(",", nums)}]--swap{nums[odd.index]}={nums[i]}");
                    nums[odd.index] = nums[i];
                    nums[i] = odd.value;
                    i--;
                }
            } else
                odds.Enqueue((i, nums[i]));
        }
        
        return nums;
    }
}