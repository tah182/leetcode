public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var anagrams = new Dictionary<string, IList<string>>();
        foreach (var str in strs) {
            var minLex = new string(str.ToCharArray().OrderBy(x => x).ToArray());
            if (anagrams.ContainsKey(minLex))
                anagrams[minLex].Add(str);
            else
                anagrams.Add(minLex, new List<string> { str });
        }

        return anagrams.Select(x => x.Value).ToList();
    }
}