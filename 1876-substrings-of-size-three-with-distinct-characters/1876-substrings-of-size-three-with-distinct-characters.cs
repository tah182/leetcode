public class Solution {
    public int CountGoodSubstrings(string s) {
        int distinct = 0;
        for (int i = 0; i < s.Length - 2; i++) {
            // Console.WriteLine($"checking-{s[i]}{s[i+1]}{s[i+2]}");
            if (s[i] != s[i + 1] && s[i + 1] != s[i + 2] && s[i] != s[i + 2])
                distinct++;
        }
        
        return distinct;
    }
}