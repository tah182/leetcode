public class Solution {
    public bool IsPalindrome(string s) {
        var start = 0;
        var end = s.Length - 1;
        while (start < end) {
            if (!char.IsLetter(s[start]) && !char.IsNumber(s[start])) {
                start++;
                continue;
            }
            
            if (!char.IsLetter(s[end]) && !char.IsNumber(s[end])) {
                end--;
                continue;
            }
            
            if (char.ToLower(s[start]) == char.ToLower(s[end])) {
                start++;
                end--;
                continue;
            }
            
            return false;
        }
        
        return true;
    }
}