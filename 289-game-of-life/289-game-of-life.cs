public class Solution {
    (int x, int y)[] neighbors = new (int x, int y)[] {
        (-1, -1),
        (-1, 0),
        (-1, 1),
        (0, -1),
        (0, 1),
        (1, -1),
        (1, 0),
        (1, 1)
    };
    
    public void GameOfLife(int[][] board) {
        var answers = new int[board.Length][];
        for (int i = 0; i < board.Length; i++) {
            answers[i] = new int[board[i].Length];
            for (int j = 0; j < board[i].Length; j++) {
                var live = aliveNeighbors(board, i, j);
                if (board[i][j] == 0 && live == 3) {
                    answers[i][j] = 1;
                } else if (board[i][j] == 1) {
                    if (live < 2)
                        answers[i][j] = 0;
                    else if (live > 3)
                        answers[i][j] = 0;
                    else
                        answers[i][j] = 1;
                } else
                    answers[i][j] = board[i][j];
            }
        }
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                board[i][j] = answers[i][j];
            }
        }
    }
    
    public int aliveNeighbors(int[][] board, int i, int j) {
        int liveNeighbors = 0;
        foreach (var neighbor in neighbors) {
            if (i + neighbor.x >= 0 && i + neighbor.x < board.Length && j + neighbor.y < board[0].Length && j + neighbor.y >= 0)
                liveNeighbors += board[i + neighbor.x][j + neighbor.y];
        }
        return liveNeighbors;
    }
}