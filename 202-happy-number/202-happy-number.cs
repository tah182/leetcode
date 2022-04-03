public class Solution {
    Dictionary<int, bool> prevNum = new Dictionary<int, bool>();
    
    public bool IsHappy(int n) {
        var numArray = n.ToString().ToCharArray().Select(c => c - '0');
        Console.WriteLine($"numberArray [{string.Join(",", numArray)}]");
        var nextNum = numArray.Aggregate(0, (curr, val) => curr + val * val);
        Console.WriteLine($"sumSquare = {nextNum}");
        
        if (prevNum.ContainsKey(nextNum))
            return false;
        prevNum.Add(nextNum, true);
        
        if (nextNum == 1)
            return true;
        else 
            return IsHappy(nextNum);
    }
}