// using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        int end = s.Length - 1;
        for(int start = 0; start < end;) {
            if (!char.IsLetterOrDigit(s[start])) {
                start++;
                continue;
            }
                
            if (!char.IsLetterOrDigit(s[end])) {
                end--;
                continue;
            }
            
            if (char.ToLower(s[start]) != char.ToLower(s[end]))
                return false;
            
            start++;
            end--;
        }
        return true;
    }
}