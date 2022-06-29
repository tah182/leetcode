public class Solution {
    private List<(int x, int y)> adjacent = new List<(int x, int y)> {
        (0, 1), (0, -1), (-1, 0), (1, 0)
    };
    
    public int MaxAreaOfIsland(int[][] grid) {
        var maxSize = 0;
        for (int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 1) {
                    maxSize = Math.Max(maxSize, IslandSize(i, j, ref grid)); 
                }
            }
        }
        return maxSize;
    }
    
    private int IslandSize(int r, int c, ref int[][] grid) {
        if (grid[r][c] == 0) return 0;
        
        var islandSize = 1;
        grid[r][c] = 0;
        foreach (var adj in adjacent) {
            if (r + adj.x >= 0
                && r + adj.x < grid.Length
               && c + adj.y >= 0
               && c + adj.y < grid[0].Length)
                islandSize += IslandSize(r + adj.x, c + adj.y, ref grid);
        }
        return islandSize;
    }
}