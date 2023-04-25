public class SmallestInfiniteSet {
    private HashSet<int> isPresent;
    private PriorityQueue<int, int> addedIntegers;
    private int currentInteger;
    
    public SmallestInfiniteSet() {
        isPresent = new HashSet<int>();
        addedIntegers = new PriorityQueue<int, int>();
        currentInteger = 1;
    }
    
    public int PopSmallest() {
        int answer;
        if (addedIntegers.TryDequeue(out answer, out _)) {
            isPresent.Remove(answer);
        }
        
        else {
            answer = currentInteger;
            currentInteger += 1;
        }
        return answer;        
    }
    
    public void AddBack(int num) {
        if (currentInteger <= num || isPresent.Contains(num))
            return;
        
        addedIntegers.Enqueue(num, num);
        isPresent.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */