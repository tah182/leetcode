public class Solution {
    public bool ValidPalindrome(string s) {
        return isPalindrome(s.ToArray(), 0, s.Length - 1, false);
    }
    
    bool isPalindrome(char[] s, int left, int right, bool skippedOnce) {
        // special cases
        if (left >= right)
            return true;
        
        //Console.WriteLine($"{s} checking {s[left]} v {s[right]} -- skippedOnce: {skippedOnce}");
        
        if (s[left] == s[right])
            return isPalindrome(s, left + 1, right - 1, skippedOnce);
        
        if (!skippedOnce)
        {
            if (s[left] == s[right - 1] && s[left + 1] == s[right])
                return isPalindrome(s, left + 1, right - 2, true) || isPalindrome(s, left + 2, right - 1, true);
            if (s[left] == s[right - 1])
                return isPalindrome(s, left + 1, right - 2, true);
            if (s[left + 1] == s[right])
                return isPalindrome(s, left + 2, right - 1, true);
        }
        
        return false;
    }
}