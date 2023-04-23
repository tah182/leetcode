public class Solution {
    public int Reverse(int x) {
        int solution = 0;
        while (x != 0) {
            int pop = x % 10;
            x /= 10;
            if (solution > int.MaxValue / 10 || (solution == int.MaxValue / 10 && pop > 7))
                return 0;
            if (solution < int.MinValue / 10 || (solution == int.MinValue / 10 && pop < -8))
                return 0;
            
            solution = solution * 10 + pop;
        }
        
        return solution;
    }
}