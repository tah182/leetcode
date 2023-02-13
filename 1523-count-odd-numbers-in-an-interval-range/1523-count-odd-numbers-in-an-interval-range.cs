public class Solution {
    public int CountOdds(int low, int high) {
        var count = 0;
        if (low % 2 == 1) {
            low++;
            count++;
        }
        
        if (high % 2 == 1 && high > low) {
            high--;
            count++;
        }
        
        if (low < high)
            count += (high - low) / 2;
        
        return count;
    }
}