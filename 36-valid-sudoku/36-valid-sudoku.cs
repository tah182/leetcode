public class Solution {
    HashSet<int> checkSum = new HashSet<int>();
    public bool IsValidSudoku(char[][] board) {
        return IsValidRows(board) && IsValidCols(board) && IsValidSquares(board);
    }
    
    bool IsValidRows(char[][] board) {
        foreach (var row in board) {
            checkSum.Clear();
            foreach(char c in row) {
                if (c == '.')
                    continue;
                
                if (!checkSum.Add(c - '0'))
                    return false;
            }
        }
        return true;
    }
    
    bool IsValidCols(char[][] board) {
        for(int col = 0; col < 9; col++) {
            checkSum.Clear();
            for (int row = 0; row < 9; row++) {
                if (board[row][col] == '.')
                    continue;
                if (!checkSum.Add(board[row][col] - '0'))
                    return false;
            }
        }
        return true;
    }
    
    bool IsValidSquares(char[][] board) {
        (int x, int y)[] squares = new (int x, int y)[9] {
            (-1, -1),
            (-1, 0),
            (-1, 1),
            (0, -1),
            (0, 0),
            (0, 1),
            (1, -1),
            (1, 0),
            (1, 1)
        };
        (int x, int y)[] mids = new (int x, int y)[9] {
            (1, 1),
            (1, 4),
            (1, 7),
            (4, 1),
            (4, 4), 
            (4, 7),
            (7, 1),
            (7, 4),
            (7, 7)
        };
        
        foreach (var mid in mids) {
            checkSum.Clear();
            foreach(var square in squares) {
                if (board[mid.x + square.x][mid.y + square.y] == '.')
                    continue;
                
                if (!checkSum.Add(board[mid.x + square.x][mid.y + square.y] - '0'))
                    return false;
            }
        }
        return true;
    }
}