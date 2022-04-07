public class Solution {
    public bool IsValid(string s) {
        var queue = new Queue<char>();
        foreach(char c in s) {
            queue.Enqueue(c);
        }
        
        //Console.WriteLine($"[{string.Join(",", queue)}]");
        var stack = new Stack<char>();
        while (queue.Count > 0) {
            var check = queue.Dequeue();
            
            if (stack.Count == 0) {
                stack.Push(check);
                continue;
            } 
            
            //Console.WriteLine($"checking [{check}] v [{stack.Peek()}]");
            switch (check) {
                case ')':
                    if (stack.Peek() == '(') 
                        stack.Pop();
                    else
                        stack.Push(check);
                    break;
                case '}' :
                    if (stack.Peek() == '{')
                        stack.Pop();
                    else
                        stack.Push(check);
                    break;
                case ']' :
                    if (stack.Peek() == '[')
                        stack.Pop();
                    else 
                        stack.Push(check);
                    break;
                default :
                    stack.Push(check);
                    break;
            }
            //Console.WriteLine($"[{string.Join(",", stack)}]");
        }
        
        return stack.Count == 0;
    }
    
}