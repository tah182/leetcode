public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var count = 0;
        
        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                var emptyLeft = (i == 0) || flowerbed[i - 1] == 0;
                var emptyRight = (i == flowerbed.Length - 1) || flowerbed[i + 1] == 0;
                
                if (emptyLeft && emptyRight) {
                    flowerbed[i] = 1;
                    count++;
                }
            }
        }
        
        return count >= n;
    }
}