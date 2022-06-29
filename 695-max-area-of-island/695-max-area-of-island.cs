public class Solution {
    private List<(int x, int y)> adjacent = new List<(int x, int y)> {
        (0, 1), (0, -1), (-1, 0), (1, 0)
    };
    private int[][] _grid;
    
    public int MaxAreaOfIsland(int[][] grid) {
        var maxSize = 0;
        _grid = grid;
        for (int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[0].Length; j++) {
                if (_grid[i][j] == 1) {
                    maxSize = Math.Max(maxSize, IslandSize(i, j)); 
                }
            }
        }
        return maxSize;
    }
    
    private int IslandSize(int r, int c) {
        if (_grid[r][c] == 0) return 0;
        
        var islandSize = 1;
        _grid[r][c] = 0;
        foreach (var adj in adjacent) {
            if (r + adj.x >= 0
                && r + adj.x < _grid.Length
               && c + adj.y >= 0
               && c + adj.y < _grid[0].Length)
                islandSize += IslandSize(r + adj.x, c + adj.y);
        }
        return islandSize;
    }
}