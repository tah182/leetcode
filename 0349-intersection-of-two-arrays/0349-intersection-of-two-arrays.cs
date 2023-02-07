public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> intersect = new List<int>();
        HashSet<int> map = new HashSet<int>();
        for (int i = 0; i < nums1.Length; i++) {
            if (!map.Contains(nums1[i])) map.Add(nums1[i]);
        }
        
        for (int i = 0; i < nums2.Length; i++) {
            if (map.Contains(nums2[i])) {
                intersect.Add(nums2[i]);
                map.Remove(nums2[i]);
            }
        }
        return intersect.ToArray();
    }
}