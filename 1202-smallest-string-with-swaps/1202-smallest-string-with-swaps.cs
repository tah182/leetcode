public class Solution {
    const int N = 100001;
    bool[] visited = new bool[N];
    List<int>[] adj = new List<int>[N]; 
    
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        for (int i = 0; i < s.Length; i++) {
            adj[i] = new List<int>();
        }
        
        // Build the adjacency list
        foreach (var edge in pairs) {
            int source = edge[0];
            int destination = edge[1];
            
            // Undirected edge
            adj[source].Add(destination);
            adj[destination].Add(source);
        }
        
        char[] answer = new char[s.Length];
        for (int vertex = 0; vertex < s.Length; vertex++) {
            // If not covered in the DFS yet
            if (!visited[vertex]) {
                var characters = new List<char>();
                var indices = new List<int>();
                
                DFS(s, vertex, characters, indices);
                // Sort the list of characters and indices
                characters = characters.OrderBy(a => a).ToList();
                indices = indices.OrderBy(a => a).ToList();

                // Store the sorted characters corresponding to the index
                for (int index = 0; index < characters.Count; index++) {
                    answer[indices[index]] = characters[index];
                }
            }
        }
        return string.Join("", answer);
    }
    
    private void DFS(String s, int vertex, List<char> characters, List<int> indices) {
        // Add the character and index to the list
        characters.Add(s[vertex]);
        indices.Add(vertex);
        
        visited[vertex] = true;
        
        // Traverse the adjacents
        foreach (int adjacent in adj[vertex]) {
            if (!visited[adjacent]) {
                DFS(s, adjacent, characters, indices);
            }
        }
    }
}