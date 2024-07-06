public class Solution {
    public bool IsPowerOfTwo(int n) {
        return n >= 1 && (n & (n - 1)) == 0;
    }
}