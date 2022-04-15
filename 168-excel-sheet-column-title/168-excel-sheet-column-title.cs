public class Solution {
    public string ConvertToTitle(int columnNumber) {
        return columnNumber == 0 ? "" : ConvertToTitle(--columnNumber / 26) + (char)(columnNumber % 26 + 'A');
    }
}