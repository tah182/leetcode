public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var row = new HashSet<char>[9];
        var col = new HashSet<char>[9];
        var block = new HashSet<char>[9];
        // initialize
        for (int i = 0; i < 9; i++) {
            row[i] = new HashSet<char>();
            col[i] = new HashSet<char>();
            block[i] = new HashSet<char>();
        }
        
        for (int i = 0 ; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') continue;
                
                // row
                if (row[i].Contains(board[i][j])) {
                    // Console.WriteLine($"for [{i}][{j}]=row{i} -- encountered dup {board[i][j]} in row");
                    return false;
                } else {
                    // Console.WriteLine($"for [{i}][{j}]=row{i} -- adding {board[i][j]} in row");
                    row[i].Add(board[i][j]);   
                }
                
                // col
                if (col[j].Contains(board[i][j])) {
                    // Console.WriteLine($"for [{i}][{j}]=col{j} -- encountered dup {board[i][j]} in col");
                    return false;
                } else {
                    // Console.WriteLine($"for [{i}][{j}]=col{j} -- adding {board[i][j]} in col");
                    col[j].Add(board[i][j]);
                }
                
                // block
                if (block[i / 3 * 3 + j / 3].Contains(board[i][j])) {
                    // Console.WriteLine($"for [{i}][{j}]=block{i / 3 * 3 + j / 3} -- encountered dup {board[i][j]} in block");
                    return false;
                } else {
                    // Console.WriteLine($"for [{i}][{j}]=block{i / 3 * 3 + j / 3} -- adding {board[i][j]} in block");
                    block[i / 3 * 3 + j / 3].Add(board[i][j]);
                }
            }
        }
        return true;
    }
}