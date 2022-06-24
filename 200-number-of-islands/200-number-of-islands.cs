public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1') {
                    count++;
                    MarkNeighbors(i, j, ref grid);
                }
            }
        }
        return count;
    }
    
    public void MarkNeighbors(int r, int c, ref char[][] grid) {
        if (grid[r][c] == '0')
            return;
        
        grid[r][c] = '0';
        if (r > 0) MarkNeighbors(r - 1, c, ref grid);
        if (c > 0) MarkNeighbors(r, c - 1, ref grid);
        if (r < grid.Length - 1) MarkNeighbors(r + 1, c, ref grid);
        if (c < grid[r].Length - 1) MarkNeighbors(r, c + 1, ref grid);
    }
}