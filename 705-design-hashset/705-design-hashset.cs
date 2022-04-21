public class MyHashSet {
    List<int>[] hash;
    
    public MyHashSet() {
        hash = new List<int>[11];
    }
    
    public void Add(int key) {
        if (hash[key % 11] == null)
            hash[key % 11] = new List<int> { key };
        else {
            if (!hash[key % 11].Contains(key))
                hash[key % 11].Add(key);
        }
    }
    
    public void Remove(int key) {
        if (hash[key % 11] != null)
            hash[key % 11].Remove(hash[key % 11].SingleOrDefault(k => k == key));
    }
    
    public bool Contains(int key) {
        if (hash[key % 11] != null)
            return hash[key % 11].Contains(key);
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