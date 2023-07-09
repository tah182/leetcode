public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = string.Empty;
        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++) {
            if (i >= word1.Length) 
                return result + word2.Substring(i, word2.Length - i);
            if (i >= word2.Length)
                return result + word1.Substring(i , word1.Length - i);
            
            result += $"{word1[i]}{word2[i]}";
            
            // Console.WriteLine($"word1[{i}]={word1[i]} || word2[{i}]={word2[i]} || result [{result}]");
        }
        
        return result;
    }
}