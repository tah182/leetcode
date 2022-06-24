public class Solution {
    public int RemovePalindromeSub(string s) {
        var counter = 0;
        var remaining = s;
        int i = 0, j = s.Length - 1;
        while (remaining.Length > 0) {
            remaining = "";
            while(i <= j) {
                if(s[i] == s[j]) {
                    i++;
                    j--;
                }
                else {
                    remaining += s[i];
                    i++;
                }
            }
            counter++;
        }
        return counter;
    }
}