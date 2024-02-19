public class Solution {
    public void MoveZeroes(int[] nums) {
        int zerosSize = 0; 
        for (int i = 0; i < nums.Length; i++){
	        if (nums[i] == 0){
                zerosSize++; 
            } else if (zerosSize > 0) {
	            int t = nums[i];
	            nums[i] = 0;
	            nums[i-zerosSize] = t;
            }
        }
    }
}