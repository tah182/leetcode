public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var mapst = new Dictionary<char, char>();
        var mapts = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            if (mapst.ContainsKey(s[i]) && mapst[s[i]] != t[i])
                return false;
            
            if (mapts.ContainsKey(t[i]) && mapts[t[i]] != s[i])
                return false;
            
            if (!mapst.ContainsKey(s[i])) 
                mapst.Add(s[i], t[i]);
            if (!mapts.ContainsKey(t[i]))
                mapts.Add(t[i], s[i]);
        }
        
        return true;
    }
}