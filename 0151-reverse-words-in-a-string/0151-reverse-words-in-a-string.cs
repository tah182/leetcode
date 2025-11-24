public class Solution {
    public string ReverseWords(string s) {
        string str = s.Trim();
        string[] words = str.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        string res = string.Join(" ",words);
        return res;
    }
}