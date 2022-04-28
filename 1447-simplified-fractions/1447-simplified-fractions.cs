public class Solution {
    public IList<string> SimplifiedFractions(int n) {
        var results = new List<string>();
        if (n <= 1 )
            return results;
        
        while (n > 1) {
            for (int top = n - 1; top > 0; top--) {
                // Console.WriteLine($"top[{top}]n[{n}]{gcd(top, n)}");
                if (top == 1)
                    results.Add($"{top}/{n}");
                else if (gcd(top, n) == 1)
                    results.Add($"{top}/{n}");
            }
            n--;
        }
        return results;
    }
    
    int gcd(int a, int b)
    {
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }
}