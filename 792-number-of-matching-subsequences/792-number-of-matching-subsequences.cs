public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        Dictionary<char, List<int>> hm = new();
        for(int i = 0; i < s.Length; i++) {
            if(!hm.ContainsKey(s[i])) {
                hm.Add(s[i], new List<int>());
            }
            hm[s[i]].Add(i);
        }
        
        int count = 0;
        foreach(var str in words) {
            int index = -1;
            int i;
            for(i = 0; i < str.Length; i++) {
                bool flag = true;
                if(!hm.ContainsKey(str[i])) {
                    break;
                }
                foreach(var j in hm[str[i]]) {
                    if(j > index) {
                        index = j;
                        flag = false;
                        break;
                    }
                }
                if(flag) {
                    break;
                }
            }
            if(i == str.Length) {
                count++;
            }
        }
        return count;
    }
}