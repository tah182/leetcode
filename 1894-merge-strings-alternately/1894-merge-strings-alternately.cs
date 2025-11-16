public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var shorter = int.Min(word1.Length, word2.Length);
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < shorter; i++) {
            answer.Append(word1[i]);
            answer.Append(word2[i]);
        }

        if (word1.Length == shorter && word2.Length != shorter)
            answer.Append(word2.Substring(shorter));
        if (word2.Length == shorter && word1.Length != shorter)
            answer.Append(word1.Substring(shorter));

        return answer.ToString();
    }
}