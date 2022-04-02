public class Solution {
    private Dictionary<char, char[]> numbers = new Dictionary<char, char[]>();
    
    public IList<string> LetterCombinations(string digits) {
        numbers.Add('2', new char[]{'a', 'b', 'c'});
        numbers.Add('3', new char[]{'d', 'e', 'f'});
        numbers.Add('4', new char[]{'g', 'h', 'i'});
        numbers.Add('5', new char[]{'j', 'k', 'l'});
        numbers.Add('6', new char[]{'m', 'n', 'o'});
        numbers.Add('7', new char[]{'p', 'q', 'r', 's'});
        numbers.Add('8', new char[]{'t', 'u', 'v'});
        numbers.Add('9', new char[]{'w', 'x', 'y', 'z'});
        
        if (digits == "")
            return new List<string>();
        
        return recur(digits, 0);
    }
    
    private List<string> recur(string digits, int digitIndex) {
        //Console.Write($"digits[{digits}]-index[{digitIndex}]");
        if (digitIndex == digits.Length - 1)
            return numbers[digits[digitIndex]].Select(c => c.ToString()).ToList();
        
        var strings = new List<string>();
        foreach (var c in numbers[digits[digitIndex]]) {
            var prevStrings = recur(digits, digitIndex + 1);
            foreach (var prevString in prevStrings) {
                //Console.WriteLine($"add [{c}] to [{prevString}]");
                strings.Add(c.ToString() + prevString);
            }
        }
        
        //Console.WriteLine($"stringsCreated: [{string.Join(",", strings)}]");
        return strings;
    }
}