public class Solution {
    public int PercentageLetter(string s, char letter) {
        return (int)(s.Count(c => c == letter) * 1.0 / s.Length * 100);
    }
}