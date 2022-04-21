public class MyHashSet {
    Dictionary<int, List<int>> hash;
    
    public MyHashSet() {
        hash = new Dictionary<int, List<int>>();
    }
    
    public void Add(int key) {
        if (hash.ContainsKey(key % 11)) {
            if (!hash[key % 11].Any(k => k == key))
                hash[key % 11].Add(key);       
        } else
            hash.Add(key % 11, new List<int> { key });
    }
    
    public void Remove(int key) {
        if (hash.ContainsKey(key % 11)) 
            hash[key % 11].Remove(hash[key % 11].SingleOrDefault(k => k == key));
    }
    
    public bool Contains(int key) {
        if (hash.ContainsKey(key % 11))
            return hash[key % 11].Any(k => k == key);
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */