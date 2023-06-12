public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var returnVal = new List<string>();
        if (!nums.Any()) return returnVal;
        
        var temp = nums[0];
        var initial = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == temp + 1) {
                temp = nums[i];
                continue;
            } else {
                pushValues(temp, initial, ref returnVal);
                initial = temp = nums[i];
            }
        }
        
        pushValues(temp, initial, ref returnVal);
        
        return returnVal;
    }
    
    public void pushValues(int temp, int initial, ref List<string> returnVal) {
        if (initial == temp)
            returnVal.Add(initial.ToString());
        else
            returnVal.Add($"{initial}->{temp}");
    }
}