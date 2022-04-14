public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 3)
            return n;
        int[] a = new int[3] { 1, 2, 3 };
        for(int i = 3; i < n + 1; i++) {
            a[2] = (a[0] + a[1]);
            a[0] = a[1];
            a[1] = a[2];
        }
        return a[2];
    }
}