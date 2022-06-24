public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] != color)
            Fill(sr, sc, image[sr][sc], color, ref image);
        
        return image;
    }
    
    public void Fill (int r, int c, int color, int newColor, ref int[][] image) {
        if (image[r][c] == color) {
            image[r][c] = newColor;
            
            if (r >= 1)
                Fill(r - 1, c, color, newColor, ref image);
            if (c >= 1)
                Fill(r, c - 1, color, newColor, ref image);
            if (r + 1 < image.Length)
                Fill(r + 1, c, color, newColor, ref image);
            if (c + 1 < image[0].Length)
                Fill(r, c + 1, color, newColor, ref image);
        }
    }
}