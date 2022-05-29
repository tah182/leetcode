public class Solution {
    private HashSet<char>[] hashedWords;
    
    public int MaxProduct(string[] words) {
        hashedWords = new HashSet<char>[words.Length];
        var maxWords = 0; 
        
        for (int i = 0; i < words.Length - 1; i++) {
            if (hashedWords[i] == null) 
                hashedWords[i] = hashWord(words[i]);
                
            for (int j = i + 1; j < words.Length; j++) {
                if (hashedWords[j] == null) hashedWords[j] = hashWord(words[j]);
                if (!HasDup(hashedWords[i], hashedWords[j]))
                    maxWords = Math.Max(maxWords, words[i].Length * words[j].Length);
            }
        }
        return maxWords;
    }
    
    public HashSet<char> hashWord(string word) {
        var hashed = new HashSet<char>();
        foreach (var c in word) {
            if (!hashed.Contains(c))
                hashed.Add(c);
        }
        return hashed;
    }
    
    private bool HasDup(HashSet<char> word1, HashSet<char> word2) {
        foreach (var c in word2) {
            if (word1.Contains(c))
                return true;
        }
        return false;
    }
}