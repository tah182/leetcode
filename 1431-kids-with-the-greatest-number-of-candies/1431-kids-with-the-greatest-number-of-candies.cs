public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = int.MinValue;
        foreach (var x in candies) 
            max = Math.Max(max, x);
        
        var returnVal = new List<bool>();
        foreach (var x in candies) {
            returnVal.Add(x + extraCandies >= max);
        }
        
        return returnVal;
    }
}