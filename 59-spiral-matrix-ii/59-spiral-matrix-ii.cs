public class Solution {
    public int[][] GenerateMatrix(int n) {
        var matrix = new int[n][];
        for (int i = 0; i < n; i++) {
            matrix[i] = new int[n];
        }
        
        int counter = 1, x = 0, y = 0, direction = 0;
        while (counter <= n * n) {
            // Console.WriteLine($"direction:{direction}");
            switch (direction) {
                case 0:
                    // going right
                    while (y < n && matrix[x][y] == 0) {
                        // Console.WriteLine($"value [{counter}] inserted at ({x},{y})");
                        matrix[x][y] = counter++;
                        y++;
                    }
                    y--;
                    x++;
                    direction = 1;
                    break;
                case 1:
                    // going down
                    while (x < n && matrix[x][y] == 0) {
                        // Console.WriteLine($"value [{counter}] inserted at ({x},{y})");
                        matrix[x][y] = counter++;
                        x++;
                    }
                    x--;
                    y--;
                    direction = 2;
                    break;
                case 2:
                    while(y >= 0 && matrix[x][y] == 0) {
                        // Console.WriteLine($"value [{counter}] inserted at ({x},{y})");
                        matrix[x][y] = counter++;
                        y--;
                    }
                    y++;
                    x--;
                    direction = -1;
                    break;
                case -1:
                    while (matrix[x][y] == 0) {
                        // Console.WriteLine($"value [{counter}] inserted at ({x},{y})");
                        matrix[x][y] = counter++;
                        x--;
                    }
                    x++;
                    y++;
                    direction = 0;
                    break;
            }
        }
        return matrix;
    }
}