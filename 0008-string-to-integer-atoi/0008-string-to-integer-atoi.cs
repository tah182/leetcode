public class Solution {
    public int MyAtoi(string s) {
        string atoi = "";
        bool isPrecedingWhitespace = true;
        foreach (var c in s) {
            if (c == ' ' && isPrecedingWhitespace)
                continue;
            if (c == '-' && isPrecedingWhitespace) {
                atoi = "-";
                isPrecedingWhitespace = false;
            } else if (c == '+' && isPrecedingWhitespace)
                isPrecedingWhitespace = false;
            else if (char.IsNumber(c)) {
                isPrecedingWhitespace = false;
                atoi = atoi + c.ToString();
                int temp;
                if (!int.TryParse(atoi, out temp)) {
                    if (atoi[0] == '-')
                        return int.MinValue;
                    
                    return int.MaxValue;
                }
            } else
                break;
        }
        
        if (atoi == "" || atoi == "-") return 0;
        return int.Parse(atoi);
    }
}