public class Solution {
    public int MyAtoi(string s) {
        // ignore leading whitespace
        // if next character is -/+, default positive
        // read until no numeric is reached. if none, 0
        // change the sign
        // if out of range, make min/max of int
        // return integer
        
        string integer = "";
        bool? isPositive = null;
        foreach(char c in s) {
            // ignore leading spaces
            if (c == ' ' && isPositive == null)
                continue;
            
            if (c == '-') {
                if (isPositive != null)
                    break;
                isPositive = false;
                continue;
            }
            
            if (c == '+') {
                if (isPositive != null)
                    break;
                isPositive = true;
                continue;
            }
            
            if (c >= '0' && c <= '9') {
                if (isPositive == null)
                    isPositive = true;
                
                integer += c.ToString();
            }
            else
                break;
        }
        
        // add sign
        integer = integer.Length == 0 ? "0"
                    : isPositive != true ? "-" + integer 
                        : integer;
        //Console.Write($"input:[{s}]--parsed:[{integer}]");
        
        // try convert to int32
        int num = 0;
        if (!int.TryParse(integer, out num)) {
            if (isPositive != true)
                num = int.MinValue;
            else
                num = int.MaxValue;
        } 
        
        ///Console.WriteLine($"--result:[{num}]");
        return num;
    }
}