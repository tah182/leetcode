public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length > t.Length) return false;
        
        var s1 = 0;
        var t1 = 0;
        
        
        while (s1 < s.Length && t1 < t.Length) {
            if (s[s1] == t[t1]) {
                s1++;
                t1++;
            } else
                t1++;
        }
        
        return s1 == s.Length;
    }
}