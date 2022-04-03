public class Solution {
    Dictionary<int, List<int>> prevNum = new Dictionary<int, List<int>>();
    
    public bool IsHappy(int n) {
        var numArray = n.ToString().ToCharArray().Select(c => c - '0');
        Console.WriteLine($"numberArray [{string.Join(",", numArray)}]");
        var nextNum = numArray.Aggregate(0, (curr, val) => curr + val * val);
        Console.WriteLine($"sumSquare = {nextNum}");
        
        if (nextNum == 1)
            return true;
        
        var hash = nextNum % 9;
        List<int> hashValues = null;
        if (!prevNum.TryGetValue(hash, out hashValues))
            prevNum.Add(hash, new List<int> {nextNum});
        else {
            if (hashValues.Contains(nextNum))
                return false;
            
            hashValues.Add(nextNum);
        }
        
        return IsHappy(nextNum);
    }
}