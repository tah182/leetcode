public class Solution {
    public string IntToRoman(int num) {
        List<RomanNumeral> rNums = new List<RomanNumeral> {
            new RomanNumeral("M", 1000),
            new RomanNumeral("CM", 900),
            new RomanNumeral("D", 500),
            new RomanNumeral("CD", 400),
            new RomanNumeral("C", 100),
            new RomanNumeral("XC", 90),
            new RomanNumeral("L", 50),
            new RomanNumeral("XL", 40),
            new RomanNumeral("X", 10),
            new RomanNumeral("IX", 9),
            new RomanNumeral("V", 5),
            new RomanNumeral("IV", 4),
            new RomanNumeral("I", 1)
        };
        
        var remainder = num;
        var romanVersion = "";
        while (remainder > 0) {
            //Console.WriteLine($"num:[{num}]--remainder:[{remainder}]");
            foreach(var rNum in rNums) {
                //Console.Write($"checking if {rNum.Number} fits in {num}");
                if (remainder / rNum.Number > 0) {
                    // fits
                    //Console.WriteLine("--yes");
                    romanVersion += rNum.Letter;
                    remainder -= rNum.Number;
                    break;
                } //else 
                    //Console.WriteLine("");
            }
        }
        
        return romanVersion;
    }
    
    public class RomanNumeral {
        public RomanNumeral(string l, int n) {
            this.Letter = l;
            this.Number = n;
        }
        public string Letter { get; private set; }
        public int Number { get; private set; }
    }
}