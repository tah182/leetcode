public class Solution {
    public string AddBinary(string a, string b) {
        var carry = 0;
        var result = "";
        for (int i = 1; i <= a.Length || i <= b.Length; i++) {
            var temp = 0;
            if (a.Length - i < 0)
                temp = b[b.Length - i] - '0' + carry;
            else if (b.Length - i < 0)
                temp = a[a.Length - i] - '0' + carry;
            else
                temp = (a[a.Length - i] - '0') + (b[b.Length - i] - '0') + carry;
            
            // Console.WriteLine($"index a[{a.Length - i}] b[{b.Length - i}] temp[{temp}] result: {result}");
            if (temp > 1) {
                carry = 1;
                temp = temp - 2;
            } else
                carry = 0;
            
            result = temp.ToString() + result;
        }
        
        if (carry == 1)
            result = carry.ToString() + result;
        
        return result;
    }
}