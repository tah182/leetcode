public class Solution {
    bool?[,] memo;
    
    public bool IsMatch(string s, string p) {
        memo = new bool?[s.Length + 1, p.Length + 1];
        
        return Dp(0, 0, s, p);
    }
    
    private bool Dp(int i, int j, string s, string p) {
        if (memo[i, j] != null)
            return memo[i, j] == true;
        
        bool answer;
        if (j == p.Length)
            answer = i == s.Length;
        else {
            var firstMatch = (i < s.Length && 
                             (p[j] == s[i] || p[j] == '.'));
            
            if (j + 1 < p.Length && p[j + 1] == '*')
                answer = (Dp(i, j + 2, s, p) ||
                         firstMatch && Dp(i + 1, j, s, p));
            else
                answer = firstMatch && Dp(i + 1, j + 1, s, p);
        }
        memo[i, j] = answer;
        return answer;
    }
}