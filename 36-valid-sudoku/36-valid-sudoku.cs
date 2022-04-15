public class Solution {
    public bool IsValidSudoku(char[][] board) {
        return IsValidRows(board) && IsValidCols(board) && IsValidSquares(board);
    }
    
    bool IsValidRows(char[][] board) {
        foreach (var row in board) {
            Dictionary<char, int> checkSum = new Dictionary<char, int>();
            foreach(char c in row) {
                if (checkSum.ContainsKey(c))
                    return false;
                
                if (c != '.')
                    checkSum.Add(c, 0);
            }
        }
        return true;
    }
    
    bool IsValidCols(char[][] board) {
        for(int col = 0; col < 9; col++) {
            Dictionary<char, int> checkSum = new Dictionary<char, int>();
            for (int row = 0; row < 9; row++) {
                if (checkSum.ContainsKey(board[row][col]))
                    return false;
                
                if (board[row][col] != '.')
                    checkSum.Add(board[row][col], 0);
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
            Dictionary<char, int> checkSum = new Dictionary<char, int>();
            foreach(var square in squares) {
                // Console.WriteLine($"[{mid.x + square.x}][{mid.y + square.y}]={board[mid.x + square.x][mid.y + square.y]}");
                if (checkSum.ContainsKey(board[mid.x + square.x][mid.y + square.y]))
                    return false;
                
                if (board[mid.x + square.x][mid.y + square.y] != '.')
                    checkSum.Add(board[mid.x + square.x][mid.y + square.y], 0);
            }
        }
        return true;
    }
}