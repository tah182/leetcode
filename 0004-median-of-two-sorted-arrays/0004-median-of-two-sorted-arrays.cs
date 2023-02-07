public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var size = (nums1.Length + nums2.Length);
        
        if (size == 1) 
            return nums1.Length == 0 ? nums2[0] : nums1[0];
        
        int nums1Ptr = 0, nums2Ptr = 0;
        var nums = new int[size / 2 + 1];
        for (int i = 0; i < nums.Length; i++) {
            if (nums1Ptr >= nums1.Length) {
                nums[i] = nums2[nums2Ptr];
                nums2Ptr++;
                continue;
            }
            
            if (nums2Ptr >= nums2.Length) {
                nums[i] = nums1[nums1Ptr];
                nums1Ptr++;
                continue;
            }
            
            if (nums1[nums1Ptr] <= nums2[nums2Ptr]) {
                nums[i] = nums1[nums1Ptr];
                nums1Ptr++;
            } else {
                nums[i] = nums2[nums2Ptr];
                nums2Ptr++;
            }
        }
        
        // Console.WriteLine($"{string.Join(",", nums.ToList())}");
        if (size % 2 == 0)
            return (nums[nums.Length - 2] + nums[nums.Length - 1]) / 2.0;
        else
            return nums[nums.Length - 1];
    }
}