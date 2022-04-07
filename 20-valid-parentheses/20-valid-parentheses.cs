public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        stack.Push(s[0]);
        for (int i = 1; i < s.Length; i++) {
            //Console.WriteLine($"checking [{s[i]}] v [{stack.Peek()}]");
            switch (s[i]) {
                case ')':
                    if (stack.Any() && stack.Peek() == '(') 
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                    break;
                case '}' :
                    if (stack.Any() && stack.Peek() == '{')
                        stack.Pop();
                    else
                        stack.Push(s[i]);
                    break;
                case ']' :
                    if (stack.Any() && stack.Peek() == '[')
                        stack.Pop();
                    else 
                        stack.Push(s[i]);
                    break;
                default :
                    stack.Push(s[i]);
                    break;
            }
            //Console.WriteLine($"[{string.Join(",", stack)}]");
        }
        
        return stack.Count == 0;
    }
    
}