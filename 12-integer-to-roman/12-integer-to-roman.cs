public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int, string> rNums = new Dictionary<int, string>();
        rNums.Add(1000, "M");
        rNums.Add(900, "CM");
        rNums.Add(500, "D");
        rNums.Add(400, "CD");
        rNums.Add(100, "C");
        rNums.Add(90, "XC");
        rNums.Add(50, "L");
        rNums.Add(40, "XL");
        rNums.Add(10, "X");
        rNums.Add(9, "IX");
        rNums.Add(5, "V");
        rNums.Add(4, "IV");
        rNums.Add(1, "I");
        
        var remainder = num;
        var romanVersion = "";
        while (remainder > 0) {
            //Console.WriteLine($"num:[{num}]--remainder:[{remainder}]");
            foreach(var rNum in rNums) {
                //Console.Write($"checking if {rNum.Number} fits in {num}");
                if (remainder / rNum.Key > 0) {
                    // fits
                    //Console.WriteLine("--yes");
                    romanVersion += rNum.Value;
                    remainder -= rNum.Key;
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