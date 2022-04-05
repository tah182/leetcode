public class Solution {
    public int MaxArea(int[] height) {
        int maxVolume = 0;
        var right = height.Length - 1;
        for (var left = 0; left < right; ){ 
            maxVolume = Math.Max(maxVolume, (right - left) * Math.Min(height[left], height[right]));
            if (height[left] <= height[right])
                left++;
            else 
                right--;
        }
        return maxVolume;
    }
}