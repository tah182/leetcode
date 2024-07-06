public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (var word in words) {
            int left = 0, right = word.Length - 1;
            while (left < right) {
                if (word[left] == word[right]) {
                    left++;
                    right--;
                } else
                    break;
            }
            if (left >= right)
                return word;
        }
        return "";
    }
}