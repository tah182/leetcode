public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var map = new Dictionary<char, int>();
        foreach(var c in magazine) {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map.Add(c, 1);
        }
        
        foreach (var c in ransomNote) {
            if (map.ContainsKey(c) && map[c] > 0)
                map[c]--;
            else
                return false;
        }
        return true;
    }
}