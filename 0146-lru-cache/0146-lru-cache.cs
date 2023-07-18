public class LRUCache {
    int capacity;
    LinkedList<int[]> lru = new LinkedList<int[]>();
    Dictionary<int, LinkedListNode<int[]>> cache = new Dictionary<int, LinkedListNode<int[]>>();
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
    }

    public int Get(int key) {
        if (!cache.ContainsKey(key)) 
            return -1;
        
        updateLRU(cache[key]);
        return cache[key].Value[1];
    }

    public void Put(int key, int value) {
        if (cache.ContainsKey(key))
            cache[key].Value[1] = value;
        else {
            if (cache.Count == capacity) {
                cache.Remove(lru.First.Value[0]);
                lru.RemoveFirst();
            }
            
            cache.Add(key, new LinkedListNode<int[]>(new int[] { key, value }));
        }
            
        updateLRU(cache[key]);
    }

    private void updateLRU(LinkedListNode<int[]> node) {
        if (node.Next != null) 
            lru.Remove(node);
        if (lru.Last != node) 
            lru.AddLast(node);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */