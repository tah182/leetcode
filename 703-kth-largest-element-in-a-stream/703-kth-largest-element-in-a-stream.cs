public class KthLargest {
    List<int> nums;
    int k;
    
    public KthLargest(int k, int[] nums) {
        this.nums = nums.ToList().OrderByDescending(num => num).ToList();
        this.k = k;
    }
    
    public int Add(int val) {
        if (nums.Count == 0)
        {
            nums.Add(val);
        } else if (val <= nums[nums.Count - 1]) {
            nums.Add(val);
        } else {
            for (int i = 0; i < nums.Count; i++) {
                if (val > nums[i]) {
                    nums.Insert(i, val);
                    break;
                }
            }    
        }
        
        return nums[k - 1];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */