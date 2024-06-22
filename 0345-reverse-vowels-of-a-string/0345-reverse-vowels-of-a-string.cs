public class Solution {
    public string ReverseVowels(string s) {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        var chars = s.ToCharArray();
        int left = 0, right = chars.Length - 1;

        while (left < right) {
            var leftVowel = vowels.TryGetValue(chars[left], out _);
            var rightVowel = vowels.TryGetValue(chars[right], out _);

            if (leftVowel && rightVowel) {
                var temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
                continue;
            }

            if (!leftVowel)
                left++;

            if (!rightVowel)
                right--;
        }

        return new string(chars);
    }
}