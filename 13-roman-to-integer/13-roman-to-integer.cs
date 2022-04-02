public class Solution {
    public int RomanToInt(string s) {
        
        var total = 0;
        for (int i = 0; i < s.Length; i++) {
            Console.WriteLine($"i == {i} of {s}");
            switch (s[i]) {
                case 'M':
                    total += 1000;
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    break;
                case 'D':
                    total += 500;
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    break;
                case 'C':
                    if (i < s.Length - 1) {
                        if (s[i + 1] == 'D')
                        {
                            total += 400;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'M')
                        {
                            total += 900;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                    }
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    total += 100;
                    break;
                case 'L':
                    total += 50;
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    break;
                case 'X':
                    if (i < s.Length - 1) {
                        if (s[i + 1] == 'L')
                        {
                            total += 40;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'C')
                        {
                            total += 90;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                    }
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    total += 10;
                    break;
                case 'V':
                    total += 5;
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    break;
                default:
                    if (i < s.Length - 1) {
                        if (s[i + 1] == 'V')
                        {
                            total += 4;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                        if (s[i + 1] == 'X')
                        {
                            total += 9;
                            //Console.WriteLine($"added: {s[i]}{s[i + 1]} total [{total}]");
                            i++;
                            continue;
                        }
                    }
                    //Console.WriteLine($"added: {s[i]} total [{total}]");
                    total += 1;
                    break;
            }   
        }
        
        return total;
    }
    
}