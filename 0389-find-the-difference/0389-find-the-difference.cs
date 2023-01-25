public class Solution {
    public char FindTheDifference(string s, string t) {
        // map of char in s and occurrences
        var maps = new int[26];
        for (int i = 0; i < s.Length; i++) {
            // add from s
            maps[s[i] - 'a']++;
            // subtract from t
            maps[t[i] - 'a']--;
        }
        
        // subtract the one extra character from t
        maps[t[t.Length - 1] - 'a']--;

        for (int i = 0; i < 26; i++) {
            if (maps[i] == -1) return (char)('a' + (char)i);
        }
        
        throw new Exception("doesn't happen");
    }
}