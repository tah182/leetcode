public class Solution {
    public int LongestPalindrome(string s) {
        var letters = new Dictionary<char, int>();
        foreach (var c in s) {
            if (letters.TryGetValue(c, out _))
                letters[c]++;
            else
                letters.Add(c, 1);
        }

        var longest = 0;
        foreach (var letter in letters.OrderByDescending(x => x.Value)) {
            longest += letter.Value / 2 * 2;
            if (letter.Value % 2 == 0)
                letters.Remove(letter.Key);
            else
                letters[letter.Key] = 1;
        }

        longest += letters.Count > 0 ? 1 : 0;
        return longest;
    }
}