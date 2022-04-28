public class Solution {
    public bool IsValid(string s) {
        while (s.Length > 0) {
            for (int i = 0; i < s.Length - 2; i++) {
                if (s.Substring(i, 3) == "abc")
                    s = s.Remove(i, 3);
            }
            if (s.Length > 0 && !s.Contains("abc"))
                return false;
            
            // Console.WriteLine($"{s}");
        }
        
        return true;
    }
}