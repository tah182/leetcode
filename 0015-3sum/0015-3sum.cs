public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            int l = i + 1, r = nums.Length - 1;
            while (l < r) {
                var sum = nums[i] + nums[l] + nums[r];
                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
                else {
                    // Console.WriteLine($"sum = {sum} ==> adding: nums[{i}, {l}, {r}] values [{nums[i]}, {nums[l]}, {nums[r]}]");
                    result.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    while (l < r && nums[l] == nums[l - 1] )
                        l++;
                }
            }
        }
        return result;
    }
}

// [-4, -1, -1, 0, 1, 2]