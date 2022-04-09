public class Solution {
    public int LengthOfLastWord(string s) {
        return s.Split(" ")
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Reverse()
                .FirstOrDefault()
                ?.Length ?? 0;
        
        // return words[words.Count - 1].Length;
    }
}