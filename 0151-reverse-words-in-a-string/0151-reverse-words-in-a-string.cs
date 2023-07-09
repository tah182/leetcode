public class Solution {
    public string ReverseWords(string s) {
        return string.Join(" ", s.Split(" ").Where(x => x.Length > 0).Reverse());
    }
}