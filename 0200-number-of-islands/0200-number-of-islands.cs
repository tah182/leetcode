public class Solution {
    // up, left, right, down
    private List<(int x, int y)> neighbors = new List<(int x, int y)> {
        (-1, 0),
        (0, -1), (0, 1),
        (1, 0)
    };
    
    private HashSet<(int x, int y)> traversed = new HashSet<(int x, int y)>();
    public int NumIslands(char[][] grid) {
        var islands = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (traverse(grid, i, j)) islands++;
            }
        }
        
        return islands;
    }
    
    public bool traverse(char[][] grid, int x, int y) {
        if (grid[x][y] == '0' || traversed.Contains(new (x, y))) return false;
        
        traversed.Add(new (x, y));
        foreach (var neighbor in neighbors) {
            if (x + neighbor.x < 0 || x + neighbor.x >= grid.Length
             || y + neighbor.y < 0 || y + neighbor.y >= grid[x].Length) continue;
            
            traverse(grid, x + neighbor.x, y + neighbor.y);
        }
        
        return true;
    }
}