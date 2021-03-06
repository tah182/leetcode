public class Solution {
    private int[] dirs = new int[] { 0, 1, 0, -1, 0 };
    public int MinimumEffortPath(int[][] heights)
    {
        int r = heights.Length;
        int c = heights[0].Length;
        bool[,] visited = new bool[r,c];
        var pq = new SortedSet<(int H, int X, int Y)>();
        pq.Add((0, 0, 0));
        while (pq.Count > 0)
        {
            var cur = pq.Min;
            if (cur.X == r - 1 && cur.Y == c - 1)
                return cur.H;
            visited[cur.X, cur.Y] = true;
            pq.Remove(cur);
            for (int d = 0; d < 4; d++)
            {
                int nx = cur.X + dirs[d];
                int ny = cur.Y + dirs[d + 1];
                if(nx < 0 || nx == r || ny < 0 || ny == c || visited[nx,ny]) 
                    continue;
                int nh = Math.Max(cur.H, Math.Abs(heights[cur.X][cur.Y] - heights[nx][ny]));
                pq.Add((nh,nx,ny));
            }
        }

        return 0;
    }
}