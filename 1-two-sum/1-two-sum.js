/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    const map = new Map();
    for (let i = 0; i < nums.length; i++)
    {
        // console.log(`current ${i}:${nums[i]}`);
        if (map.has(target - nums[i])) {
            // console.log(`found: ${target - nums[i]}`);
            return [i, map.get(target - nums[i])];
        }
        map.set(nums[i], i);
    }
};