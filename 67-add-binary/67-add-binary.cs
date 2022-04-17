public class Solution {
    public string AddBinary(string a, string b) {
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;
        
        string result = "";
        var carry = 0;
        int add = 0;
        while (aIndex >= 0 || bIndex >= 0) {
            add = (aIndex >= 0 ? (a[aIndex] - '0') : 0) + 
                    (bIndex >= 0 ? (b[bIndex] - '0') : 0) + carry;
            
            if (add == 3) {
                result = "1" + result;
                carry = 1;
            } else if (add == 2) {
                result = "0" + result;
                carry = 1;
            } else {
                result = (add).ToString() + result;
                carry = 0;
            }
                
            aIndex--;
            bIndex--;
        }
        
        return carry == 1 ? "1" + result : result;
    }
}