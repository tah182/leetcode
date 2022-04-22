public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        Stack<int> evens = new Stack<int>();
        Stack<int> odds = new Stack<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] % 2 == 0)
                evens.Push(nums[i]);
            else
                odds.Push(nums[i]);
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (i % 2 == 0)
                nums[i] = evens.Pop();
            else
                nums[i] = odds.Pop();
        }
        
        return nums;
    }
}