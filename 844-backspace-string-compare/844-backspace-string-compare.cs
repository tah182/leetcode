public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var s1 = new Stack<char>();
        var t1 = new Stack<char>();
        
        foreach (var c in s) {
            if (c == '#') {
              if (s1.Count > 0)
                s1.Pop();  
            } 
            else
                s1.Push(c);
        }
        
        foreach (var c in t) {
            if (c == '#') {
                if (t1.Count > 0)
                    t1.Pop();
            }
            else 
                t1.Push(c);
        }
        
        if (s1.Count != t1.Count)
            return false;
        
        while(s1.Count > 0) {
            if (s1.Pop() != t1.Pop())
                return false;
        }
        return true;
    }
}