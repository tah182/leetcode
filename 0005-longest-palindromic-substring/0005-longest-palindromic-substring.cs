public class Solution {
    public string LongestPalindrome(string s) {
        if (s == null || s.Length < 1) return "";
        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++) {
            int len1 = expandAroundCenter(s, i, i);
            int len2 = expandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len > end - start) {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        
        return s.Substring(start, end + 1 - start);
    }
    
    private int expandAroundCenter(String s, int left, int right) {
        int l = left, r = right;
        while (l >= 0 && r < s.Length && s[l] == s[r]) {
            l--;
            r++;
        }
        return r - l - 1;
    }
}