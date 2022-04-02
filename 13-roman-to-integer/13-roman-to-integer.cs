public class Solution {
    private List<Roman> romans = new List<Roman> {
        new Roman('I', 1),
        new Roman('V', 5),
        new Roman('X', 10),
        new Roman('L', 50),
        new Roman('C', 100),
        new Roman('D', 500),
        new Roman('M', 1000)
    };
    
    public int RomanToInt(string s) {
        var total = 0;
        
        for (int i = 0; i < s.Length; i++) {
            foreach (var roman in romans) {
                if (roman.Letter == s[i]) {
                    var nextLetter = i != s.Length - 1 ? s[i+1] : '?';
                    var numerical = roman.getNumber(nextLetter);
                    if (numerical != roman.Number)
                        i++;
                    total += numerical;
                    
                    break;
                }
            }
            
        }
        
        return total;
    }
    
    class Roman {
        public Roman (char l, int n) {
            this.Letter = l;
            this.Number = n;
        }
        
        public char Letter { get; private set; }
        public int Number { get; private set; }
        public int getNumber (char nextLetter) {
            if (this.Letter == 'I' && nextLetter == 'V')
                return 4;
            if (this.Letter == 'I' && nextLetter == 'X')
                return 9;
            if (this.Letter == 'X' && nextLetter == 'L')
                return 40;
            if (this.Letter == 'X' && nextLetter == 'C')
                return 90;
            if (this.Letter == 'C' && nextLetter == 'D')
                return 400;
            if (this.Letter == 'C' && nextLetter == 'M')
                return 900;
            
            return this.Number;
        }
    }
}