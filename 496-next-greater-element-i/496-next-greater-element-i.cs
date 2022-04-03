public class Solution {
    Dictionary<int, int> indexes;
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        indexes = new Dictionary<int, int>();
        
        for(int i = 0; i < nums2.Length; i++)
            indexes.Add(nums2[i], i);
        
        for (int i = 0; i < nums1.Length; i++) {
            var startIndex = indexes[nums1[i]];
            var done = false;
            for (int j = startIndex; j < nums2.Length && !done; j++) {
                if (nums2[j] > nums1[i]) {
                    done = true;
                    nums1[i] = nums2[j];
                }
            }
            if (!done)
                nums1[i] = -1;
        }
        return nums1;
    }
    
}