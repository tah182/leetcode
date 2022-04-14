public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 3)
            return n;
        int prev = 1, current = 2, calc = 3;
        for(int i = 3; i < n + 1; i++) {
            calc = prev + current;
            prev = current;
            current = calc;
        }
        return calc;
    }
}