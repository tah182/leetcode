public class Solution {
    // up, left, right, down
    private List<(int x, int y)> neighbors = new List<(int x, int y)> {
        (-1, 0),
        (0, -1), (0, 1),
        (1, 0)
    };
    
    public int NumIslands(char[][] grid) {
        var islands = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == '1') {
                    islands++;
                    traverse(grid, i, j);
                }
            }
        }
        
        return islands;
    }
    
    public void traverse(char[][] grid, int x, int y) {        
        grid[x][y] = '0';
        foreach (var neighbor in neighbors) {
            if (x + neighbor.x < 0 || x + neighbor.x >= grid.Length
             || y + neighbor.y < 0 || y + neighbor.y >= grid[x].Length) continue;
            
            if (grid[x + neighbor.x][y + neighbor.y] == '1')
                traverse(grid, x + neighbor.x, y + neighbor.y);
        }
    }
}