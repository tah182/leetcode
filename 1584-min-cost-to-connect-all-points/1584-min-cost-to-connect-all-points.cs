public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        int result = 0;
        HashSet<int> visited = new HashSet<int>();
        int[][] graph = new int[n][];

        PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
        pq.Enqueue( (0, 0), 0);

        // Build graph
        for(int i = 0; i < n; ++i)
        {
            graph[i] = new int[n];
            for(int j = 0; j < n; ++j)
            {
                if(i != j)
                {
                    int distance = Math.Abs( points[i][0] - points[j][0]) + 
                                   Math.Abs( points[i][1] - points[j][1]);
                    graph[i][j] = distance;
                }
            }
        }

        // Do search
        while(visited.Count < n)
        {
            var (x, y) = pq.Dequeue();
            if(!visited.Contains(y))
            {
                visited.Add(y);
                result += graph[x][y];

                for(int i = 0; i < n; ++i)
                {
                    if(!visited.Contains(i))
                    {
                        pq.Enqueue( (y, i), graph[y][i]);
                    }
                }
            }
        }

        return result;
    }
}