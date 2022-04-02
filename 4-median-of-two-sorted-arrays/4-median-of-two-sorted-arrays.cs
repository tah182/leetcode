public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var updatedList = mergeAndSort(nums1, nums2);
        
        if (updatedList.Count % 2 == 0) {
            // take middle 2
            var mid = updatedList.Count / 2;
            return (updatedList[mid - 1] + updatedList[mid]) / 2.0;
        } else
            return updatedList[updatedList.Count / 2];
    }
    
    private List<int> mergeAndSort(int[] nums1, int[] nums2) {
        var updatedList = new List<int>();
        updatedList.AddRange(nums1);
        updatedList.AddRange(nums2);
        updatedList.Sort();

        return updatedList;
    }
}