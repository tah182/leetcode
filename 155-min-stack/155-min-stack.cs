public class MinStack {
    Stack<int> minimum;
    Stack<int> stack;
    public MinStack() {
        minimum = new Stack<int>();
        stack = new Stack<int>();
    }
    
    public void Push(int val) {
        if (minimum.Count == 0 || GetMin() >= val)
            minimum.Push(val);
        stack.Push(val);
    }
    
    public void Pop() {
        if (stack.Pop() == GetMin())
            minimum.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minimum.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */