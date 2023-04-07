public class Solution {
    private List<int[]> moves = new List<int[]> {
        new int[] { 0, -1 },
        new int[] { -1, 0 },
        new int[] { 1, 0 },
        new int[] { 0, 1 }
    };
    
    public int NumEnclaves(int[][] grid) {
        var total = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                var temp = Traverse(i, j, ref grid);
                if (temp > 0)
                    total += temp;
                
//                 for (int l = 0; l < grid.Length; l++) {
//                     for (int m = 0; m < grid[0].Length; m++) {
//                         Console.Write(grid[l][m]);
//                     }
//                     Console.WriteLine();
//                 }
//                 Console.WriteLine();
            }
        }
        
        return total;
    }
    
    public int Traverse(int x, int y, ref int[][] grid) {
        if (grid[x][y] == -1) return -1;
        if (grid[x][y] == 0) return 0;
        var current = 1;
        
        grid[x][y] = 0;
        foreach (var move in moves) {
            if (x + move[0] < 0 || x + move[0] >= grid.Length
             || y + move[1] < 0 || y + move[1] >= grid[0].Length) {
                grid[x][y] = -1;
                return -1;
            } else {
                var nextMove = Traverse(x + move[0], y + move[1], ref grid);
                if (nextMove == -1) {
                    grid[x][y] = -1;
                    return -1;
                } else 
                    current += nextMove;
            }
        }
        
        return current;
    }
}