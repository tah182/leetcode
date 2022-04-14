public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
            return s;
        
        string[] letters = new string[numRows];
        int currRow = 0;
        var goingUp = false;
                
        foreach (var c in s) {
            // Console.WriteLine($"C:{c} -- currRow:{currRow}");
            letters[currRow] += c;
            
            if (currRow == numRows - 1 || currRow == 0)
                goingUp = !goingUp;
            
            currRow += goingUp ? 1 : -1;
        }
        
        return string.Join("", letters);
    }
}