public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var first = new List<int> { 1 };
        var result = new List<IList<int>> { first };
        
        if (numRows == 1)
            return result;
        
        for(int currRow = 2; currRow <= numRows; currRow++) {
            first = CreateRow(first, currRow, numRows);
            result.Add(first);
        }
        return result;
    }
    
    public List<int> CreateRow(List<int> prevRow, int currRow, int numRows) {
        List<int> currList = new();
        for (int i = 0; i < currRow; i++) {
            if (i == 0 || i == currRow - 1)
                currList.Add(1);
            else 
                currList.Add(prevRow[i - 1] + prevRow[i]);
        }
        
        // Console.WriteLine($"row [{currRow}] - [{string.Join(",", currList)}]");
        
        return currList;
    }
}