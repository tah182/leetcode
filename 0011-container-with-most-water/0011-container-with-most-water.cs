public class Solution {
    public int MaxArea(int[] height) {
        int maxVolume = 0;
        var right = height.Length - 1;
        for (var left = 0; left < right; ){ 
            if (height[left] <= height[right]) {
                maxVolume = Math.Max(maxVolume, (right - left) * height[left]);
                left++;
            } else {
                maxVolume = Math.Max(maxVolume, (right - left) * height[right]);
                right--;
            } 
        }
        return maxVolume;
    }
}