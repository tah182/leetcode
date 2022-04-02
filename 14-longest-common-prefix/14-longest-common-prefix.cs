public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var finished = false;
        var index = 0;
        var longestPrefix = "";
        
        while (!finished) {
            char? temp = null;
    
            if (strs[0].Length == 0)
                return longestPrefix;
            else if (strs[0].Length > index)
                temp = strs[0][index];
            
            foreach(var word in strs) {
                //Console.WriteLine($"Checking word: [{word}]");
                if (index >= word.Length || word[index] != temp)
                {
                    finished = true;
                    break;
                }
            }
            if (!finished)
                longestPrefix += temp;
            
            //Console.WriteLine($"LP: [{longestPrefix}] -- index: [{index}]");
            index++;
        }
        
        //Console.WriteLine($"Longest prefix = {longestPrefix}");
        return longestPrefix;
    }
}