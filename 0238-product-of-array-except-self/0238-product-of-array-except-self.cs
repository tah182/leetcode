public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var temp = 1;
        
        var output = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            output[i] = temp;
            temp *= nums[i];
        }
        
        temp = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            output[i] = output[i] * temp;
            temp *= nums[i];
        }
        
        return output;
    }
    
    // time complexity => O(2n) -> O(n)
    // space complexity => O(n) ** output array
}