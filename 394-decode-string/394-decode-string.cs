public class Solution {
    public string DecodeString(string s) {
        if (s == null || s == string.Empty)
            return s;
    
        Stack<char> s1 = new Stack<char>();
        Stack<int> s2 = new Stack<int>();
        int cnt = 0;
        
        for (int i = 0; i < s.Length; i++)
            if (s[i] >= '0' && s[i] <= '9')
                cnt = cnt * 10 + (s[i] - '0');
            else if (s[i] == ']')
            {
                string cur = string.Empty;                
                while (s1.Peek() != '[')
                    cur += s1.Pop();
                
                s1.Pop();
                
                int j = s2.Pop();
                
                while (j-- > 0)
                    for (int k = cur.Length - 1; k > -1; k--)
                        s1.Push(cur[k]);
            }
            else
            {
                s1.Push(s[i]);
                
                if (s[i] == '[')
                {
                    s2.Push(cnt);
                    cnt = 0;
                }
            }
        
        Char[] res = new Char[s1.Count];
        
        while (s1.Count > 0)
            res[s1.Count - 1] = s1.Pop();
        
        return new String(res);
    }
}