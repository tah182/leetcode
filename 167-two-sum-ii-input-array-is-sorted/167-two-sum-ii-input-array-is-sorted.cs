public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int calc;
        for (int start = 0, end = numbers.Length - 1; start < end;) {
            calc = numbers[start] + numbers[end];
            if (calc == target)
                return new int[2] { start + 1, end + 1 };
            
            if (calc < target)
                start++;
            else
                end--;
        }
        return null;
    }
}