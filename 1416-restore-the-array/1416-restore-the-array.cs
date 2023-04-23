public class Solution {
    public int NumberOfArrays(string s, int k) {
        int m = s.Length, n = k.ToString().Length;
        int mod = 1000000007;
        
        int[] dp = new int[n + 1];
        dp[0] = 1;
        
        for (int start = 0; start < m; ++start) {
            if (s[start] == '0') {
                dp[start % (n + 1)] = 0;
                continue;
            }
            
            for (int end = start; end < m; ++end) {
                var currNumber = s.Substring(start, end + 1 - start);
                
                if (long.Parse(currNumber) > k)
                    break;
                
                dp[(end + 1) % (n + 1)] = (dp[(end + 1) % (n + 1)] + dp[start % (n + 1)]) % mod;
            }
            
            dp[start % (n + 1)] = 0;
        }
        return dp[m % (n + 1)];
    }
}