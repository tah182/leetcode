public class Solution {
    public bool WordPattern(string pattern, string s) {
        var strings = s.Split(" ");
        if (strings.Length != pattern.Length) return false;
        
        var patternToS = new Dictionary<char, string>();
        var SToPattern = new Dictionary<string, char>();
        
        for (int i = 0; i < pattern.Length; i++) {
            if (patternToS.ContainsKey(pattern[i])) {
                if (patternToS[pattern[i]] != strings[i]) return false;
            } else
                patternToS.Add(pattern[i], strings[i]);
        
            if (SToPattern.ContainsKey(strings[i])) {
              if (SToPattern[strings[i]] != pattern[i]) return false;  
            } else
                SToPattern.Add(strings[i], pattern[i]);
        }
        
        return true;
    }
}