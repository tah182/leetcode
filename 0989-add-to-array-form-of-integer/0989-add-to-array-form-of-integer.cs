public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        var kString = k.ToString();
        int carry = 0;
        
        var result = new List<int>();
        for (int i = 1; i < num.Length + 1 || i < kString.Length + 1; i++) {
            var temp = 0;
            if (num.Length - i < 0) 
                temp = (kString[kString.Length - i] - '0') + carry;
            else if (kString.Length - i < 0)
                temp = num[num.Length - i] + carry;
            else
                temp = (kString[kString.Length - i] - '0') + num[num.Length - i] + carry;
            
            carry = temp > 9 ? 1 : 0;
            Console.WriteLine($"i[{i}], temp = [{temp}], carry = [{carry}]");
            result.Insert(0, temp % 10);
        }
        
        if (carry == 1)
            result.Insert(0, 1);
        
        return result;
    }
}