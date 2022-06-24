public class Solution {
    void SetZeroes(int m, int n, ref int[][] matrix) {
        // go through m range;
        for (int i = 0; i < matrix.Length; i++) {
            matrix[i][n] = 0;
        }
        
        for (int i = 0; i < matrix[m].Length; i++) {
            matrix[m][i] = 0;
        }
    }
    
    public void SetZeroes(int[][] matrix) {
        var queue = new Queue<(int m, int n)>();
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                if (matrix[i][j] == 0)
                    queue.Enqueue(new (i, j));
            }
        }
        
        while (queue.Count > 0) {
            var popped = queue.Dequeue();
            SetZeroes(popped.m, popped.n, ref matrix);
        }
    }
}