public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sPointer = 0, tPointer = 0;
        while (sPointer < s.Length && tPointer < t.Length) {
            // Console.WriteLine($"s={s} sPointer={s[sPointer]} tPointer={t[tPointer]}");
            if (s[sPointer] == t[tPointer]) {
                sPointer++;
            }
            tPointer++;
        }

        return sPointer == s.Length;
    }
}