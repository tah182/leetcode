public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        Stack<int> odds = new Stack<int>();
        Stack<int> evens = new Stack<int>();
        for (int i = 0 ; i < nums.Length; i++) {
            if (nums[i] % 2 == 0)
                evens.Push(nums[i]);
            else
                odds.Push(nums[i]);
        }
        
        for (int i = 0; i < nums.Length; i++)
            if (evens.Count > 0)
                nums[i] = evens.Pop();
            else
                nums[i] = odds.Pop();
        
        return nums;
    }
}