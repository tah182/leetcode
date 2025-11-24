public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        char[] str = s.ToCharArray();

        int left = 0, right = s.Length - 1;
        while (left < right) {
            Console.WriteLine($"left: {str[left]} right: {str[right]}");
            if (vowels.Contains(str[left]) && vowels.Contains(str[right])) {
                Console.WriteLine("Swapping");
                var temp = str[left];
                str[left] = str[right];
                str[right] = temp;
                left++;
                right--;
                continue;
            }
            if (!vowels.Contains(str[left])) left++;
            if (!vowels.Contains(str[right])) right--;
        }

        return new string(str);
    }
}