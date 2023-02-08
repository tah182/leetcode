public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        return SearchNeighbor(matrix, target, 0, 0);
    }
    
    private bool SearchNeighbor(int[][] matrix, int target, int x, int y) {
        if (x >= matrix.Length || y >= matrix[x].Length)
            return false;
        
        if (target == matrix[x][y]) return true;
        if (target < matrix[x][y] || matrix[x][y] == int.MinValue) return false;
        
        // invalidate
        matrix[x][y] = int.MinValue;
        
        // check right down
        return SearchNeighbor(matrix, target, x + 1, y)
            || SearchNeighbor(matrix, target, x, y + 1);
    }
}