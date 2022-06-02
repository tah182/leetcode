public class Solution {
    public int[][] Transpose(int[][] matrix) {
        var result = new int[matrix[0].Length][];
        for (int x = 0; x < matrix.Length; x++) {
            for (int y = 0; y < matrix[x].Length; y++) {
                if (result[y] == null) result[y] = new int[matrix.Length];
                result[y][x] = matrix[x][y];
            }
        }
        return result;
    }
}