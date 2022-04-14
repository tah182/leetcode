public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 3)
            return n;
        
        List<int> a = new List<int>();
        a.Add(0);
        a.Add(1);
        a.Add(2);
        
        int i = 3;
        while(i < n + 1) {
            a.Add(a[i - 1] + a[i - 2]);
            i++;
        }
        return a[i - 1];
    }
}