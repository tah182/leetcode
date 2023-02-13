public class Solution {
    public int CountOdds(int low, int high) {
        var count = 0;
        if (low % 2 == 0) 
            low++;
        
        return low > high ? 0 : (high - low) / 2 + 1;
    }
}