public class Solution {
    public int ArraySign(int[] nums) {
        var signFunc = true;
        foreach(var num in nums) {
            if (num == 0)
                return 0;
            if (num < 0)
                signFunc = signFunc == false;
        }
        return signFunc ? 1 : -1;
    }
}