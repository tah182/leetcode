class Solution {
    public List<List<Integer>> fourSum(int[] nums, int target) {
        List<List<Integer>> result = new ArrayList<>();
        if (nums == null || nums.length < 4) {
            return result;
        }

        Arrays.sort(nums); // Sort the array to easily handle duplicates and use two pointers

        int n = nums.length;
        for (int i = 0; i < n - 3; i++) {
            // Skip duplicate for i
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            for (int j = i + 1; j < n - 2; j++) {
                // Skip duplicate for j
                if (j > i + 1 && nums[j] == nums[j - 1]) {
                    continue;
                }

                long remainingTarget = (long) target - nums[i] - nums[j]; // Use long to prevent overflow

                int left = j + 1;
                int right = n - 1;

                while (left < right) {
                    long sum = (long) nums[left] + nums[right];
                    if (sum == remainingTarget) {
                        result.add(Arrays.asList(nums[i], nums[j], nums[left], nums[right]));

                        // Skip duplicates for left
                        while (left < right && nums[left] == nums[left + 1]) {
                            left++;
                        }
                        // Skip duplicates for right
                        while (left < right && nums[right] == nums[right - 1]) {
                            right--;
                        }

                        left++;
                        right--;
                    } else if (sum < remainingTarget) {
                        left++;
                    } else {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}