public class Solution {
    public int Divide(int dividend, int divisor) {
        if (divisor == 0 | (dividend == Int32.MinValue && divisor == -1))
           return Int32.MaxValue;
        
        bool sign = (dividend > 0) ^ (divisor > 0);
        uint dd = (uint)(dividend < 0 ? -dividend : dividend);
        uint dr = (uint)(divisor < 0 ? -divisor : divisor);
        int remainder = 0;
        
        for (int i = 31; i >= 0; i--) {
            if ((dd >> i) >= dr){                
                remainder = remainder << 1 | 0x01;
                dd -= dr << i;
            } else
                remainder = remainder << 1;
        }
        return sign ? -remainder : remainder;
    }
}