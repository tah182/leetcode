public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        
        var longest = 1;
        for (int i = 0; i < s.Length - 1; i++) {
            var map = new HashSet<char>();
            map.Add(s[i]);
            var counter = 1;
            for (int j = i + 1; j < s.Length; j++) {
                if (map.Contains(s[j])) {
                    break;
                }
                
                counter++;
                map.Add(s[j]);
            }
            longest = counter > longest ? counter : longest;
        }
        return longest;
    }
}