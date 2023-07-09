public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = string.Empty;
        for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++) {
            result += $"{word1[i]}{word2[i]}";
        }
        
        if (word1.Length < word2.Length) 
            result += word2.Substring(word1.Length, word2.Length - word1.Length);
        if (word2.Length < word1.Length)
            result += word1.Substring(word2.Length, word1.Length - word2.Length);
            
        return result;
    }
}