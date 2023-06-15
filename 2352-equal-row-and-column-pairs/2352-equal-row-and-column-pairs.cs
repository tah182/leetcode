public class Solution {
    public int EqualPairs(int[][] grid) {
        int count = 0;
        
        var rowCounter = new Dictionary<string, int>();
        foreach (var row in grid) {
            string rowString = string.Join(",", row.Select(c => c.ToString()));
            
            Console.WriteLine($"rowString[{rowString}]");
            if (rowCounter.ContainsKey(rowString)) {
                rowCounter[rowString] = ++rowCounter[rowString];
            } else
                rowCounter.Add(rowString, 1);
        }
        
        for (int c = 0; c < grid.Length; c++) {
            int[] colArray = new int[grid.Length];
            for (int r = 0; r < grid.Length; ++r) {
                colArray[r] = grid[r][c];
            }
            if (rowCounter.TryGetValue(string.Join(",", colArray.Select(c => c.ToString())), out var counter)) {
                count += counter;
            }
        }
        
        return count;
    }
}