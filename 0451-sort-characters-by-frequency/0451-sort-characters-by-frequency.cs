public class Solution {
    public string FrequencySort(string s) {
        var dic = new Dictionary<char, int>();
        foreach (var c in s) {
            if (dic.TryGetValue(c, out _))
                dic[c]++;
            else
                dic.Add(c, 1);
        }

        var result = "";
        var sorted = dic.OrderByDescending(x => x.Value).ToList();
        foreach (var keyVal in sorted) {
            for (int i = 0; i < keyVal.Value; i++) {
                result += keyVal.Key;
            }
        }

        return result;
    }
}