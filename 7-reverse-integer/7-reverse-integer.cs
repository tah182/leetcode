public class Solution {
    public int Reverse(int x) {
        var reverseString = "";
        var isPositive = true;
        foreach (var c in x.ToString()) {
            if (c == '-') {
                isPositive = false;   
            } else
            {
                reverseString = c.ToString() + reverseString;   
            }
        }
        
        int answer = 0;
        int.TryParse((!isPositive ? "-" : "") + reverseString, out answer);
        
        return answer;
    }
}