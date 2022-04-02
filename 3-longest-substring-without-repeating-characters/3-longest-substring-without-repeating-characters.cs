
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        if (s.Length == 0) return longest;
        
        for (var root = 0; root < s.Length; root++) {
            var currentSubstring = s[root].ToString();
            for (var subCount = root + 1; subCount < s.Length; subCount++) {
                if (currentSubstring.Contains(s[subCount])) {
                    subCount = s.Length;
                } else {
                    currentSubstring += s[subCount];
                }
            }
            longest = longest > currentSubstring.Length ? longest : currentSubstring.Length;
        }
        return longest;
    }
}