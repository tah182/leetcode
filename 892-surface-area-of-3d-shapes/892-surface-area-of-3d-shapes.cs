public class Solution {
    public int SurfaceArea(int[][] grid) {
        var neighbors = new List<(int vert, int hor)>() {
            (-1, 0), (0, -1), (0, 1), (1, 0)
        };
        
        var surface = 0;
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[row].Length; col++) {
                if (grid[row][col] == 0) continue;
                var total = grid[row][col] * 4 + 2;
                foreach (var neighbor in neighbors) {
                    if (row + neighbor.hor >= 0 && row + neighbor.hor < grid.Length
                        && col + neighbor.vert >= 0 && col + neighbor.vert < grid[row].Length) {
                        var sum = Math.Min(grid[row + neighbor.hor][col + neighbor.vert], grid[row][col]);
                        // Console.WriteLine($"grid[{row}][{col}] - removing grid[{row + neighbor.hor}][{col + neighbor.vert}]={sum}");
                        total -= sum;
                    }
                        
                }
                // Console.WriteLine($"square[{row}][{col}]({grid[row][col]}) = {total}");
                surface += total;
            }
        }
        Console.WriteLine("\n");
        return surface;
    }
}