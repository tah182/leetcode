public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";
        if (strs.Length == 1)
            return strs[0];
        
        var longest = "";
        
        for (int i = 0; i < int.MaxValue; i++) {
            if (strs[0].Length <= i)
                return longest;
            
            var current = (strs[0])[i];
            foreach (var str in strs) {
                if (str.Length <= i)
                    return longest;
                
                if (str[i] != current)
                    return longest;
            }
            longest = longest + current;
        }
        return longest;
    }
}