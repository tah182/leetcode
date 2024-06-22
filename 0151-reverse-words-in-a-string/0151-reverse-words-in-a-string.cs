public class Solution {
    public string ReverseWords(string s) {
        var words = s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        int left = 0, right = words.Length - 1;

        while (left < right) {
            var temp = words[left];
            words[left] = words[right];
            words[right] = temp;
            left++;
            right--;
        }
        return String.Join(" ", words);
    }
}