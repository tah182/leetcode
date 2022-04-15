public class Solution {
    public bool CheckValid(int[][] matrix) {
        HashSet<int> check = new HashSet<int>();
        
        for(int row = 0; row < matrix.Length; row++){
            check.Clear();
            for (int col = 0; col < matrix.Length; col++) {
                if (!check.Add(matrix[row][col]))
                    return false;
            }
        }
        
        for(int row = 0; row < matrix.Length; row++){
            check.Clear();
            for (int col = 0; col < matrix.Length; col++) {
                if (!check.Add(matrix[col][row]))
                    return false;
            }
        }
        
        return true;
    }
}