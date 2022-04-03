public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        return SwapMatches(s1, s2, 0, 1);
    }
    
    public bool SwapMatches(string s1, string s2, int left, int right) {
        if (s1 == s2)
            return true;
        if (s2.Length == 1)
            return false;
        
        //Console.Write($"swapped [{s1}] {left} with {right} to ");
        // swap and check
        var charArr = s1.ToCharArray();
        var swap = charArr[left];
        charArr[left] = charArr[right];
        charArr[right] = swap;
        if (string.Join("", charArr) == s2) {
            //Console.WriteLine($"{string.Join("", charArr)} against {s2}... matched");
            return true;
        }
        
        //Console.WriteLine($"{string.Join("", charArr)} against {s2}");
        
        if (left == s1.Length - 2)
            return false;
        if (right == s1.Length - 1)
            return SwapMatches(s1, s2, left + 1, left + 2);
        else
            return SwapMatches(s1, s2, left, right + 1);
    }
}