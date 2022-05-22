public class Solution {
    public string ReorderSpaces(string text) {
        var spaces = text.Count(t => t == ' ');
        var words = text.Split(' ').Where(t => t != "").ToList();
        
        Console.WriteLine($"[{string.Join(",", words)}] spaces - {spaces}");
        
        if (spaces == 0)
            return text;
        if (words.Count() <= 1)
            return words[0] + new string(' ', spaces);
        
        text = "";
        for (int i = 0; i < words.Count() - 1; i++) {
            text += words[i] + new string(' ', spaces / (words.Count() - 1));
        }
        
        return text + words[words.Count - 1] + new string(' ', spaces % (words.Count - 1));
    }
}