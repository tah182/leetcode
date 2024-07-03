public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var currentLetter = 'c';
        for (int i = 0; ; i++) {
            for (int j = 0; j < strs.Length; j++) {
                if (i >= strs[j].Length)
                    return strs[j].Substring(0, i);

                if (j == 0)
                    currentLetter = strs[j][i];
                else if (currentLetter != strs[j][i])
                    return strs[j].Substring(0, i);
            }
        }

        return strs[0];
    }
}