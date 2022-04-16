public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum = 0, multiplier = 0;
        foreach(var c in columnTitle.ToCharArray().Reverse()) {
            sum += (int)((c - 'A' + 1) * Math.Pow(26, multiplier));
            multiplier++;
        }
        return sum;
    }
}