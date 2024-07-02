public class Solution {
    public bool IsPalindrome(int x) {
        var test = x.ToString();
        
        int left = 0, right = test.Length - 1;
        while (left < right) {
            if (test[left] != test[right])
                return false;
            
            left++;
            right--;
        }

        return true;
    }
}