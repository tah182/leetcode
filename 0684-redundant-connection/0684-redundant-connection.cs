public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int[] parent = new int[edges.Length + 1];
        int[] rank = new int[edges.Length + 1];
        
        for (int i = 0; i < edges.Length + 1; i++) {
            parent[i] = i;
            rank[i] = 1;
        }
        
        foreach (var edge in edges) {
            if (!Union(edge[0], edge[1], ref parent, ref rank))
                return new int[] { edge[0], edge[1] };
        }
        
        return null;
    }
    
    private int Find(int n, ref int[] parent) {
        var p = parent[n];
        while (p != parent[p]) {
            // Console.WriteLine($"looking for p {p}");
            p = parent[p] = parent[parent[p]];
        }
        
        return p;
    }
    
    private bool Union(int n1, int n2, ref int[] parent, ref int[] rank) {
        // Console.WriteLine($"n1 [{n1}] n2 [{n2}]");
        var p1 = Find(n1, ref parent);
        var p2 = Find(n2, ref parent);
        
        if (p1 == p2) return false;
        
        if (rank[p1] > rank[p2]) {
            parent[p2] = p1;
            rank[p1] += rank[p2];
        } else {
            parent[p1] = p2;
            rank[p2] += rank[p1];
        }
        
        return true;
    }
}