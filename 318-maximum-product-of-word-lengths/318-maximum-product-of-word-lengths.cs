public class Solution {
    public int MaxProduct(string[] words) {
        var maxWords = 0; 
        for (int i = 0; i < words.Length - 1; i++){
            var wordHash = new HashSet<char>();
            foreach (var c in words[i]) {
                if (!wordHash.Contains(c))
                    wordHash.Add(c);
            }
            for (int j = i + 1; j < words.Length; j++) {
                if (!containsDups(wordHash, words[j]))
                    maxWords = Math.Max(maxWords, words[i].Length * words[j].Length);
            }
        }
        return maxWords;
    }
    
    private bool containsDups(HashSet<char> word1, string word2) {
        foreach (var c in word2) {
            if (word1.Contains(c))
                return true;
        }
        return false;
    }
}