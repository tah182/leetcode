public class Solution {
    public void ReverseString(char[] s) {
        int left = 0;
        char temp;
        for (int right = s.Length - 1; left < right; right--, left++) {
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;
        }
    }
}