public class Solution {
    public bool IsPowerOfTwo(int n) {
        return Math.Log2(n) % 1 == 0;
    }
}