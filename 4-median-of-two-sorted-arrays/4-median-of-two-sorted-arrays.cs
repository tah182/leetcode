public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var updatedList = mergeAndSort(nums1, nums2);
        
        if (updatedList.Length % 2 == 0) {
            // take middle 2
            var mid = updatedList.Length / 2;
            return (updatedList[mid - 1] + updatedList[mid]) / 2.0;
        } else
            return updatedList[updatedList.Length / 2];
    }
    
    private int[] mergeAndSort(int[] nums1, int[] nums2) {
        var updatedList = new List<int>();
        updatedList.AddRange(nums1);
        updatedList.AddRange(nums2);

        return updatedList.OrderBy(b => b).ToArray();
    }
}