public class Solution {
    public int[] PlusOne(int[] digits) {
        var carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] + carry == 10) {
                if (i == 0) {
                    digits[i] = 0;
                    var newList = new List<int> { 1 };
                    newList.AddRange(digits);
                    return newList.ToArray();
                } else {
                    digits[i] = 0;
                    carry = 1;
                }
            } else {
                digits[i] += 1;
                break;
            }
        }
        return digits;
    }
}