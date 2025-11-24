public class Solution {
    public string ReverseWords(string s) {
        List<string> words = s.Split(" ").ToList();
        StringBuilder returnVal = new StringBuilder();
        for (int i = words.Count - 1; i >= 0; i--) {
            var trimmedWord = words[i].Trim();
            returnVal.Append(trimmedWord);
            if (trimmedWord.Length > 0) returnVal.Append(" ");
        }
        return returnVal.ToString().Trim();
    }
}