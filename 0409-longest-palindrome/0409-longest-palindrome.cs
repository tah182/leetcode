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
        var isOdd = false;
        foreach (var letter in letters) {
            if (letter.Value % 2 == 0)
                longest += letter.Value;
            else {
                longest += letter.Value - 1;
                isOdd = true;
            }
        }

        return isOdd ? longest + 1 : longest;
    }
}