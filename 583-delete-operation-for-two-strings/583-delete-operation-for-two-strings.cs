public class Solution {
    public int MinDistance(string word1, string word2) {
        int[,] dp = new int[word1.Length + 1, word2.Length + 1];
        for(int i = 0; i <= word1.Length; i++) {
            for (int j = 0; j <= word2.Length; j++) {
                if (i == 0 || j == 0) continue;
                if (word1[i - 1] == word2[j - 1])
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                
                // Console.Write($"{dp[i, j]}\t");
            }
            // Console.WriteLine();
        }
        
        // for (int i = 0; i < dp.GetLength(0); i++)
        // {
        //     for (int j = 0; j < dp.GetLength(1); j++)
        //     {
        //         Console.Write(dp[i,j] + "\t");
        //     }
        //     Console.WriteLine();
        // }
        
        return word1.Length + word2.Length - 2 * dp[word1.Length, word2.Length];
    }
}