public class Solution {
    public int CalPoints(string[] ops) {
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < ops.Length; i++) {
            switch (ops[i]) {
                case "+":
                    int num = stack.Pop();
                    int total = stack.Peek() + num;
                    stack.Push(num);
                    stack.Push(total);
                    break;
                case "D":
                    stack.Push(stack.Peek() * 2);
                    break;
                case "C":
                    stack.Pop();
                    break;
                default:
                    stack.Push(int.Parse(ops[i]));
                    break;
            }
        }
        
        var sum = 0;
        while(stack.Count > 0)
            sum += stack.Pop();
        
        return sum;
    }
}