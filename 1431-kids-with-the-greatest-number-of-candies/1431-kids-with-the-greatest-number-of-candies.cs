public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = 0;
        for (int i = 0; i < candies.Length; i++) {
            maxCandies = int.Max(candies[i], maxCandies);
            candies[i] += extraCandies;
        }

        List<bool> mostCandies = new List<bool>();
        foreach (var candy in candies) {
            mostCandies.Add(candy >= maxCandies);
        }

        return mostCandies;
    }
}