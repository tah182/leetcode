public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) {
            if (dict.ContainsKey(target - numbers[i]))
                return new int[] { dict[target - numbers[i]] + 1, i + 1 };
            
            if (!dict.ContainsKey(numbers[i]))
                dict.Add(numbers[i], i);
        }
        
        return null;
    }
}