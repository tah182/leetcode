public class Solution {
    public int MakeArrayIncreasing(int[] arr1, int[] arr2) {
        var dp = new Dictionary<int, int>();
        Array.Sort(arr2);
        var n = arr2.Length;
        dp.Add(-1, 0);
        
        for (int i = 0; i < arr1.Length; i++) {
            var newDp = new Dictionary<int, int>();
            foreach (var prev in dp.Keys.ToArray()) {
                if (arr1[i] > prev) {
                    if (!newDp.ContainsKey(arr1[i]))
                        newDp.Add(arr1[i], Math.Min(newDp.GetValueOrDefault(arr1[i], int.MaxValue), dp[prev]));    
                    else 
                        newDp[arr1[i]] = Math.Min(newDp.GetValueOrDefault(arr1[i], int.MaxValue), dp[prev]);
                } 
                int idx = bisectRight(arr2, prev);
                if (idx < n) {
                    if (!newDp.ContainsKey(arr2[idx]))
                        newDp.Add(arr2[idx], Math.Min(newDp.GetValueOrDefault(arr2[idx], int.MaxValue), 1 + dp[prev]));
                    else 
                        newDp[arr2[idx]] = Math.Min(newDp.GetValueOrDefault(arr2[idx], int.MaxValue), 1 + dp[prev]);
                }
            }
            dp = newDp;
        }
        
        int answer = int.MaxValue;
        foreach (var value in dp.Values.ToArray())
            answer = Math.Min(answer, value);
        
        return answer == int.MaxValue ? -1 : answer;
    }
    
    private static int bisectRight(int[] arr, int value) {
        int left = 0, right = arr.Length;
        while (left < right) {
            int mid = (left + right) / 2;
            if (arr[mid] <= value)
                left = mid + 1;
            else
                right = mid;
        }
        
        return left;
    }
}