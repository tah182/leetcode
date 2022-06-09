public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++) {
            if (map.ContainsKey(target - numbers[i]))
                return new int[2] { map[target - numbers[i]] + 1, i + 1 };
            
            if (!map.ContainsKey(numbers[i]))
                map.Add(numbers[i], i);
        }
        
        return null;
    }
}