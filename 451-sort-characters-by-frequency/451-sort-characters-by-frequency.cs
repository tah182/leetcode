public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (var c in s) {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else 
                frequency.Add(c, 1);
        }
        
        string returnVal = "";
        foreach (var keyVal in frequency.OrderByDescending(c => c.Value)) {
            for (int i = 0 ; i < keyVal.Value; i++) {
                returnVal += keyVal.Key;
            }
        }
        return returnVal;
    }
}