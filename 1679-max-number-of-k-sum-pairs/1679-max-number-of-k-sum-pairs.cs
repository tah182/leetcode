public class Solution {
    public int MaxOperations(int[] nums, int k) {
        if(nums?.Length == 0){
            return 0;
        }
        
        int result = 0;
        Array.Sort(nums);
        int i = 0;
        int j = nums.Length - 1;
        
        while(i < j){
            
            if(nums[i] + nums[j] == k){
                result++;
                i++;
                j--;
            }
            else if(nums[i] + nums[j] < k){
                i++;
            }
            else{
                j--;
            }
        }
        
        return result;
    }
}