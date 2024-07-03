public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> closeOpen = new Dictionary<char, char>(); 
        closeOpen.Add(')', '(');
        closeOpen.Add('}', '{');
        closeOpen.Add(']', '[');

        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (closeOpen.TryGetValue(c, out var open) && stack.Count() > 0) {
                if (open == stack.Peek()) {
                    stack.Pop();
                } else {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count() == 0;
    }
}