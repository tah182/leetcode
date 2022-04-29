public class Solution {
    public bool IsBipartite(int[][] graph) {        
        bool?[] codes = new bool?[graph.Length];
        for(int i = 0; i < graph.Length; i++) {
            if(codes[i] == null && !dfs(i, graph, false, codes )) {
                return false;
            }
        }
        
        return true;
    }
    
    private bool dfs(int node, int[][] graph, bool currentCode, bool?[] codes) {
        if(codes[node] == null) {
            codes[node] = currentCode;
            for( int i =0; i < graph[node].Length; i++) {
                if(!dfs(graph[node][i], graph, !currentCode, codes)) {
                    return false;
                }
            }

            return true;
        }
        
        return codes[node] == currentCode;
    }
}