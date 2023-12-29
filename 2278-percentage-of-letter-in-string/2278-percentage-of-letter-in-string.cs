public class Solution {
    public int PercentageLetter(string s, char letter) {
        int counter = 0;
        for (int i = 0; i < s.Length; i++) {
            counter += s[i] == letter ? 1 : 0;
        }
        
        return (int)(counter * 1.0 / s.Length * 100);
    }
}