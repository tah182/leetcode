public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int greatest = -1;
        for (int i = 0 ; i < candies.Length; i++) {
            greatest = Math.Max(candies[i], greatest);
            candies[i] += extraCandies;
        }
        
        var result = new bool[candies.Length];
        for (int i = 0 ; i < candies.Length; i++)
            result[i] = candies[i] >= greatest;
        
        return result.ToList();
    }
}