public class Solution {
    public string LongestPalindrome(string s) {
        var longestPalindrome = "";
        
        if (s.Length == 1)
            return s;
        
        for(var left = 0; left < s.Length; left++) {
            for(var right = s.Length - 1; right >= left && right - left + 1 > longestPalindrome.Length; right--) {
                //Console.WriteLine($"Checking[{s.Substring(left, right - left + 1)}]");
                if (isPalindrome(s, left, right)) {
                    if (right - left + 1 > longestPalindrome.Length) {
                        longestPalindrome = s.Substring(left, right - left + 1);
                    }
                } 
            }
        }
        
        if (longestPalindrome.Length == 0)
            return s.Substring(0, 1);
        
        return longestPalindrome;
    }
    
    public bool isPalindrome(string s, int left, int right) {
        if (left < right && s[left] == s[right]) { 
            // palindrome so far, recurse
            return isPalindrome(s, left + 1, right - 1);
        } else if (left == right) {
            return true;   
        }
        else if (left > right)  {
            // crossed midpoint, done
            return true;
        }
        
        return false;           // didn't meet match, not palindrome
    }
}