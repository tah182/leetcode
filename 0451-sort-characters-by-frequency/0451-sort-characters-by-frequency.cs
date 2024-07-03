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
        var list = dic.ToList();
        list.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        foreach (var keyVal in list) {
            for (int i = 0; i < keyVal.Value; i++) {
                result += keyVal.Key;
            }
        }

        return result;
    }
}