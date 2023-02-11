public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        for (int i = cost.Length - 2; i >= 0; i--) {
            cost[i] += Math.Min(cost[i + 1], i == cost.Length - 2 ? 0 : cost[i + 2]);
        }
        return Math.Min(cost[0], cost[1]);
    }
}
