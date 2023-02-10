class Solution {
    public int MaxDistance(int[][] grid) {
        int rows = grid.Length;
        // Although it's a square matrix, using different variable for readability.
        int cols = grid[0].Length;
        
        // Maximum manhattan distance possible + 1.
        int MAX_DISTANCE = rows + cols + 1;

        int[][] dist = new int[rows][];
        for (int i = 0; i < rows; i++) {
            dist[i] = new int[cols];
            for (int j = 0; j < cols; j++) {
                dist[i][j] = MAX_DISTANCE;
            }
        }

        // First pass: check for left and top neighbours
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                // Distance of land cells will be 0.
                if (grid[i][j] == 1) {
                    dist[i][j] = 0;
                } else {
                    // Check left and top cell distances if they exist and update the current cell distance.
                    dist[i][j] = Math.Min(dist[i][j], Math.Min(i > 0 ? dist[i - 1][j] + 1 : MAX_DISTANCE,
                                                               j > 0 ? dist[i][j - 1] + 1 : MAX_DISTANCE));
                }
            }
        }

        // Second pass: check for the bottom and right neighbours.
        int ans = int.MinValue;
        for (int i = rows - 1; i >= 0; i--) {
            for (int j = cols - 1; j >= 0; j--) {
                // Check the right and bottom cell distances if they exist and update the current cell distance.
                dist[i][j] = Math.Min(dist[i][j], Math.Min(i < rows - 1 ? dist[i + 1][j] + 1 : MAX_DISTANCE,
                                                           j < cols - 1 ? dist[i][j + 1] + 1 : MAX_DISTANCE));
                
                ans = Math.Max(ans, dist[i][j]);
            }
        }

        // If ans is 0, it means there is no water cell,
        // If ans is MAX_DISTANCE, it implies no land cell.
        return ans == 0 || ans == MAX_DISTANCE ? -1 : ans;
    }
};