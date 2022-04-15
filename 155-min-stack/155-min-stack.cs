public class MinStack {
    List<int> vals;
    public MinStack() {
        vals = new List<int>();
    }
    
    public void Push(int val) {
        vals.Add(val);
    }
    
    public void Pop() {
        vals.RemoveAt(vals.Count - 1);
    }
    
    public int Top() {
        return vals[vals.Count - 1];
    }
    
    public int GetMin() {
        return vals.Min();
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