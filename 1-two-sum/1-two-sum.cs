public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // return the indices of the numbers that add sum to target
        // GUARANTEED ONE answer
        //Console.WriteLine($"input: [{string.Join(",", nums)}]");
        //var answer = FindIndices(nums, target, 0, 1);
        
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target)
                    return new int[2] { i, j };
            }
        }
        
        return null;
        
        //Console.WriteLine($"answer: [{string.Join(",", answer)}]");
        //return answer;
    }
    
    public int[] FindIndices(int[] nums, int target, int left, int right) {
        // special case, we've reached the end on right
        if (right >= nums.Length) {
            left++;
            right = left + 1;
            return FindIndices(nums, target, left, right);
        }
        
        //Console.WriteLine($"Checking: L[{left}]={nums[left]} + R[{right}]={nums[right]}");
        
        // match
        if (nums[left] + nums[right] == target)
            return new int[2] { left, right };
        
        // else, just increment right
        right = right + 1;
        return FindIndices(nums, target, left, right);
    }
}