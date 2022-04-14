public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
            return s;
        
        string[] letters = new string[numRows];
        int currRow = 0;
        var goingUp = true;
                
        foreach (var c in s) {
            // Console.WriteLine($"C:{c}");
            letters[currRow] += c;
            
            if (goingUp) {
                if (currRow == numRows - 1)
                {
                    goingUp = !goingUp;
                    currRow--;
                } else
                    currRow++;
            } else {
                if (currRow == 0) {
                    goingUp = !goingUp;
                    currRow++;
                } else
                    currRow--;
            }
        }
        
        return string.Join("", letters);
    }
}