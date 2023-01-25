public class Solution {
    public char FindTheDifference(string s, string t) {
        // map of char in s and occurrences
        var dict = new Dictionary<char, int>();
        foreach (var l in s) {
            if (dict.ContainsKey(l))
                dict[l]++;
            else
                dict.Add(l, 1);
        }

        // remove matches from s using t
        foreach (var l in t) {
            // new letter found. return
            if (!dict.ContainsKey(l))
                return l;
            // if letter exist, keep subtracting occurrence
            else {
                if (dict[l] == 1)
                    dict.Remove(l);
                else
                    dict[l]--;
            }
        }

        throw new Exception("this should not occur.");
    }
}