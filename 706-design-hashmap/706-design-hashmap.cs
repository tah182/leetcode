public class MyHashMap {
    List<KeyVal>[] map;
    public MyHashMap() {
        map = new List<KeyVal>[11];
    }
    
    public void Put(int key, int value) {
        var temp = map[key % 11];
        if (temp == null)
            map[key % 11] = new List<KeyVal> { new KeyVal(key, value ) };
        else {
            if (temp.Any(k => k.Key == key)) 
                map[key % 11].Single(k => k.Key == key).Val = value;
            else
                map[key % 11].Add(new KeyVal(key, value));
        }
    }
    
    public int Get(int key) {
        var temp = map[key % 11];
        if (temp != null && temp.Any(k => k.Key == key)) 
            return temp.Single(k => k.Key == key).Val;
        
        return -1;
    }
    
    public void Remove(int key) {
        var temp = map[key % 11];
        if (temp != null && temp.Any(k => k.Key == key)) {
            temp.Remove(temp.Single(k => k.Key == key));
        }
    }
    
    class KeyVal {
        public KeyVal(int key, int val) {
            this.Key = key;
            this.Val = val;
        }
        public int Key {get;set;}
        public int Val {get;set;}
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */