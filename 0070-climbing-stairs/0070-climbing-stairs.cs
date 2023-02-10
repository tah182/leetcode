public class Solution {
    private Dictionary<int, int> cache = new Dictionary<int, int>(); // holds tree head as key, steps as value
    public int ClimbStairs(int n) {
        if (n == 0) return 0;
        
        return Dfs(1, n) + Dfs(2, n);
    }
    
    private int Dfs(int current, int n) {
        if (current == n) return 1;
        if (current > n) return 0;
        
        if (cache.ContainsKey(current)) return cache[current];
                
        var value = Dfs(current + 1, n) + Dfs(current + 2, n);
        cache.Add(current, value);
        return value;
    }
}