public class MyHashMap {
    int?[] map;
    public MyHashMap() {
        map = new int?[1000001];
    }
    
    public void Put(int key, int value) {
        map[key] = value;
    }
    
    public int Get(int key) {
        var val = map[key];
        return val ?? -1;
    }
    
    public void Remove(int key) {
        map[key] = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */