public class Solution {
    public string RemoveDuplicates(string s) {
        for (int i = 0; i < s.Length - 1; ++i) {
            // Console.WriteLine($"i[{i}], check string [{s}] on [{s[i]}] vs [{s[i + 1]}]");
            if (s[i] == s[i + 1]) {
                // Console.WriteLine($"@{i} found dup of [{s[i]}] && [{s[i + 1]}]");
                var left = i > 0 ? s.Substring(0, i) : "";
                var right = (i < s.Length - 2) ? s.Substring(i + 2, s.Length - (i + 2)) : "";
                s = left + right;
                // Console.WriteLine($"s == {s}");
                i = (i - 2 >= -1) ? i - 2: -1;
                // Console.WriteLine($"new i={i}");
            }
        }
        
        return s;
    }
}