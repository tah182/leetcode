public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        List<int> flat = new List<int>();
        foreach(var list in grid) {
            flat.AddRange(list);
        }
        
        while(k > 0) {
            flat.Insert(0, flat[flat.Count - 1]);
            flat.RemoveAt(flat.Count - 1);
            k--;
        }
        
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                grid[i][j] = flat[k];
                k++;
            }
        }
        return grid;
    }
}