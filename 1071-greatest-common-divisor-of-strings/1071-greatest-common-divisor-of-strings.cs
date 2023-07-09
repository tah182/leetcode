public class Solution {
    private static int gcd(int x, int y) {
        if (y == 0) 
            return x;
        return gcd(y, x % y);
    }
    
    public string GcdOfStrings(string str1, string str2) {
        if (!(str1 + str2 == str2 + str1)) 
            return string.Empty;
        
        int gcdLength = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }
}