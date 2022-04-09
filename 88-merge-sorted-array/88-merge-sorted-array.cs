public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var m1 = 0;
        var n1 = 0;
        List<int> merged = new List<int>();
        
        while (m1 < m || n1 < n) {
            Console.WriteLine($"m1[{m1}]--n1[{n1}]");
            if (m1 == m) {
                merged.Add(nums2[n1]);
                n1++;
            } else if (n1 == n) {
                merged.Add(nums1[m1]);
                m1++;
            } else if (nums1[m1] < nums2[n1]) {
                merged.Add(nums1[m1]);
                m1++;
            } else {
                merged.Add(nums2[n1]);
                n1++;
            }
            Console.WriteLine($"[{string.Join(",", merged)}]");
        }   
        
        for(int i = 0; i < merged.Count; i++) {
            nums1[i] = merged[i];
        }
    }
}