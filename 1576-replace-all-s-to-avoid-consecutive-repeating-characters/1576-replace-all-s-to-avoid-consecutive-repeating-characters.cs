public class Solution {
    public string ModifyString(string s) {
        var returnVal = "";
        for (int i = 0 ; i < s.Length; i++) {
            if (s[i] == '?') {
                var left = i == 0 ? '%' : returnVal[i - 1];
                var right = i == s.Length - 1 ? '%' : s[i + 1];
                var done = false;
                // Console.Write($"left[{left}]:right[{right}]");
                for (var j = 'a'; j <= 'z' && !done; j++) {
                    if (j != left && j != right) {
                        // Console.WriteLine($"---added[{j}]");
                        returnVal += j;
                        done = true;
                    }
                }
            } else
                returnVal += s[i];
        }
        return returnVal;
    }
}