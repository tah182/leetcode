public class Solution {
    public int PercentageLetter(string s, char letter) {
        int counter = 0;
        int count = 0;
        for (int i = 0; i < s.Length; i++) {
            count++;
            counter += s[i] == letter ? 1 : 0;
        }
        
        return (int)(counter * 1.0 / count * 100);
    }
}