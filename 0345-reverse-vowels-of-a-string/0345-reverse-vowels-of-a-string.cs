public class Solution {
    public string ReverseVowels(string s) {
        var left = 0;
        var right = s.Length - 1;
        var charArray = s.ToArray();
        
        while (left < right) {
            if (isVowel(charArray[left]) && isVowel(charArray[right])) {
                var swap = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = swap;
                
                left++;
                right--;
                continue;
            }
            
            if (isVowel(charArray[left])) {
                right--;
                continue;
            }
            
            if (isVowel(charArray[right])) {
                left++;
                continue;
            }
            
            left++;
            right--;
        }
        
        return new string(charArray);
    }
    
    private static bool isVowel(char c) {
        return "aAeEiIoOuU".IndexOf(c) >= 0;
    }
}