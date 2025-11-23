public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        return (str1 + str2 == str2 + str1) 
           ? str1.Substring(0, (int)BigInteger.GreatestCommonDivisor(str1.Length, str2.Length)) 
           : "";
    }
}