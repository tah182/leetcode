public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
            return s;
        
        List<List<char>> letters = new List<List<char>>();
        int currRow = 0;
        var goingUp = true;
        
        for(int i = 0; i < numRows; i++) {
            letters.Add(new List<char>());
        }
        
        foreach (var c in s) {
            // Console.WriteLine($"C:{c}");
            letters[currRow].Add(c);
            
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
        string returnString = "";
        foreach(var row in letters) {
            foreach (var c in row) {
                returnString += c.ToString();
            }
        }
        return returnString;
    }
}