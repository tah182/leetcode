public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();
        foreach (var c in s) {
            if (map.TryGetValue(c, out var _)) 
                map[c]++;
            else
                map.TryAdd(c, 1);
        }
        
        foreach (var c in t) {
            if (map.TryGetValue(c, out var item)) {
                if (item == 0)
                    return false;
                
                map[c]--;
            } else
                return false;
        }

        return true;
    }
}