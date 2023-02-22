public class Solution {
    private bool isFeasible(int[] weights, int c, int days) {
        int daysNeeded = 1, currentLoad = 0;
        foreach (int weight in weights) {
            currentLoad += weight;
            if (currentLoad > c) {
                daysNeeded++;
                currentLoad = weight;
            }
        }
        
        return daysNeeded <= days;
    }
    
    public int ShipWithinDays(int[] weights, int days) {
        int totalLoad = 0, maxLoad = 0;
        foreach (int weight in weights) {
            totalLoad += weight;
            maxLoad = Math.Max(maxLoad, weight);
        }
        
        int l = maxLoad, r = totalLoad;
        
        while (l < r) {
            int mid = (l + r) / 2;
            if (isFeasible(weights, mid, days))
                r = mid;
            else
                l = mid + 1;
        }
        
        return l;
    }
}