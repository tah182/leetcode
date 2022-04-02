public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var updatedList = nums1.ToList();
        updatedList.AddRange(nums2);
        updatedList = updatedList.OrderBy(b => b).ToList();
        
        if (updatedList.Count % 2 == 0) {
            // take middle 2
            var mid = updatedList.Count / 2;
            return (updatedList[mid - 1] + updatedList[mid]) / 2.0;
        } else
            return updatedList[updatedList.Count / 2];
    }
}