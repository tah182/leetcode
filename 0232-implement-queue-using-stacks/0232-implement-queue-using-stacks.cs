public class MyQueue {
    private Stack<int> stack1;
    private Stack<int> stack2;

    public MyQueue() {
        stack1 = new ();
        stack2 = new ();
    }
    
    public void Push(int x) {
        while (stack1.Count > 0) {
            stack2.Push(stack1.Pop());
        }

        stack1.Push(x);
        while (stack2.Count > 0) {
            stack1.Push(stack2.Pop());
        }
    }
    
    public int Pop() {
        return stack1.Pop();
    }
    
    public int Peek() {
        return stack1.Peek();
    }
    
    public bool Empty() {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */