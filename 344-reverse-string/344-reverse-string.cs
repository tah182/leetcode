public class Solution {
    public void ReverseString(char[] s) {
        int left = 0, right = s.Length - 1;
        char temp;
        while(left < right) {
            temp = s[left];
            s[left++] = s[right];
            s[right--] = temp;
        }
    }
}