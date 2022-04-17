public class Solution {
    public string AddBinary(string a, string b) {
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;
        
        string result = "";
        var carry = 0;
        while (aIndex >= 0 || bIndex >= 0) {
            switch ((aIndex >= 0 ? (a[aIndex] - '0') : 0) + 
                    (bIndex >= 0 ? (b[bIndex] - '0') : 0) + carry) {
                case 3:
                    result = "1" + result;
                    carry = 1;    
                    break;
                case 2:
                    result = "0" + result;
                    carry = 1;    
                    break;
                default:
                    result = ((aIndex >= 0 ? (a[aIndex] - '0') : 0) + 
                    (bIndex >= 0 ? (b[bIndex] - '0') : 0) + carry).ToString() + result;
                    carry = 0;
                    break;
            }
                
            aIndex--;
            bIndex--;
        }
        
        return carry == 1 ? "1" + result : result;
    }
}