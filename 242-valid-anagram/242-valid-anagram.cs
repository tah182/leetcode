public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach(char c in s) {
            if (letters.ContainsKey(c))
                letters[c]++;
            else
                letters.Add(c, 1);
        }
        
        // foreach(var key in letters) {
        //     Console.WriteLine($"letter={key.Key}->{key.Value}");
        // }
        
        foreach (var c in t) {
            if (!letters.ContainsKey(c)) {
                // Console.WriteLine($"can't find {c} in letters");
                return false;   
            }
            if (letters[c] == 1)
                letters.Remove(c);
            else
                letters[c]--;
        }
        
        return !letters.Any();
    }
}