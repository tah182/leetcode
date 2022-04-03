public class Solution {
    public int ArraySign(int[] nums) {
        var signFunc = 1;
        foreach(var num in nums) {
            if (num == 0)
                return 0;
            if (num < 0)
                signFunc *= -1;
        }
        return signFunc;
    }
}