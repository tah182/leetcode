public class Solution {
    List<(int x, int y)> neighbors = new List<(int x, int y)> {
            (-1, 0),
        (0, -1), (0, 1),
        (1, 0)
        };
    public int MaxAreaOfIsland(int[][] grid) {
        var maxArea = 0;
        for (int i = 0 ; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1)
                    maxArea = Math.Max(maxArea, AddNeighbors(grid, i, j));
            }
        }
        
        return maxArea;
    }
    
    public int AddNeighbors(int[][] grid, int x, int y) {
        if (x < 0 || y < 0 || x >= grid.Length || y >= grid[x].Length || grid[x][y] == 0)
            return 0;
        
        grid[x][y] = 0;
        var area = 1;
        foreach (var neighbor in neighbors) {
            area += AddNeighbors(grid, x + neighbor.x, y + neighbor.y);
        }
        
        // Console.WriteLine($"for block: [{x}][{y}] area={area}");
        return area;
    }
}