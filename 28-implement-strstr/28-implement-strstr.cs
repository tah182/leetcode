public class Solution {
    public int StrStr(string haystack, string needle) {
        if (string.IsNullOrWhiteSpace(needle))
            return 0;
        
        for(int i = 0; i < haystack.Length - needle.Length + 1; i++) {
            Console.WriteLine($"check {string.Join("", haystack.Skip(i).Take(needle.Length))}");
            if (string.Join("", haystack.Skip(i).Take(needle.Length)) == needle)
                return i;
        }
        return -1;
    }
}