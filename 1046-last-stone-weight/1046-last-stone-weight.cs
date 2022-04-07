public class Solution {
    public int LastStoneWeight(int[] stones) {
        var stonesList = stones.ToList();
        while (stonesList.Count > 1) {
            stonesList = compareTwoHeaviest(stonesList);
        }
               
       return stonesList.Any() ? stonesList[0] : 0;
    }
    
    public List<int> compareTwoHeaviest(List<int> stones) {
        stones = stones.OrderByDescending(b => b).ToList();
        if (stones[0] == stones[1])
        {
            stones.RemoveAt(0);
            stones.RemoveAt(0);
        } else {
            stones[0] = stones[0] - stones[1];
            stones.RemoveAt(1);
        }
        return stones;
    }
}