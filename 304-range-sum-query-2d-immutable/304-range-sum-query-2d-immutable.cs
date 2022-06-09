public class NumMatrix {

    private readonly int[][] _matrix;
    public NumMatrix(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return;
        
        _matrix = new int[matrix.Length + 1][];
        for (int row = 0; row < matrix.Length; row++) {
            if (_matrix[row] == null)
                _matrix[row] = new int[matrix[0].Length + 1];
            _matrix[row + 1] = new int[matrix[0].Length + 1];
            for (int col = 0; col < matrix[0].Length; col++) {
                _matrix[row + 1][col + 1] = _matrix[row + 1][col] + _matrix[row][col + 1] + matrix[row][col] - _matrix[row][col];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return _matrix[row2 + 1][col2 + 1] - _matrix[row1][col2 + 1] - _matrix[row2 + 1][col1] + _matrix[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */