public class Solution {
    public int FirstUniqChar(string s) {
        var letterIndex = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (letterIndex.ContainsKey(s[i]))
                letterIndex[s[i]] = -1;
            else 
                letterIndex.Add(s[i], 1);
        }

        for (int i = 0; i < s.Length; i++) {
            if (letterIndex[s[i]] == 1)
                return i;
        }
        return -1;
    }
}