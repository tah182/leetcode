using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        Regex regex = new Regex("[^a-zA-Z0-9]");
        s = regex.Replace(s, String.Empty).ToLower();
        // Console.WriteLine($"{s}");
        // Console.WriteLine($"{string.Join("", s.ToCharArray().Reverse())}");
        return s == string.Join("", s.ToCharArray().Reverse());
    }
}