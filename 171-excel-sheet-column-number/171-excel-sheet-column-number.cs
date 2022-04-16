public class Solution {
    public int TitleToNumber(string columnTitle) {
        int sum = 0;
        for (int i = columnTitle.Length - 1; i >= 0; i--) {
            sum += (int)((columnTitle[i] - 'A' + 1) * Math.Pow(26, columnTitle.Length - 1 - i));
        }
        return sum;
    }
}