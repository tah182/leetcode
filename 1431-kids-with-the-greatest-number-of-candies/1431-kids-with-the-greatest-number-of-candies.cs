public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int greatest = -1;
        foreach (var kid in candies)
            greatest = Math.Max(kid, greatest);
        
        var result = new List<bool>();
        foreach (var kid in candies)
            result.Add(kid + extraCandies >= greatest);
        
        return result;
    }
}