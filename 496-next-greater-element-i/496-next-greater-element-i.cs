public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        for (int i = 0; i < nums1.Length; i++) {
            var found = false;
            var done = false;
            for (int j = 0; j < nums2.Length && !done; j++) {
                if (found && nums2[j] > nums1[i]) {
                    done = true;
                    nums1[i] = nums2[j];
                } else if (nums2[j] == nums1[i])
                    found = true;
            }
            if (!done)
                nums1[i] = -1;
        }
        return nums1;
    }
    
}