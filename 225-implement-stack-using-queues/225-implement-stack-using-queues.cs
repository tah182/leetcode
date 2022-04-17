public class MyStack {
    Queue<int> queue;
    Queue<int> temp;
    
    public MyStack() {
        queue = new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    public int Pop() {
        temp = new Queue<int>();
        int lastVal = 0;
        while (queue.Count > 0) {
            lastVal = queue.Dequeue();
            if (queue.Count != 0)
                temp.Enqueue(lastVal);
        }
        queue = temp;
        return lastVal;
    }
    
    public int Top() {
        temp = new Queue<int>();
        int lastVal = 0;
        while (queue.Count > 0) {
            lastVal = queue.Dequeue();
            temp.Enqueue(lastVal);
        }
        queue = temp;
        return lastVal;
    }
    
    public bool Empty() {
        return queue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */