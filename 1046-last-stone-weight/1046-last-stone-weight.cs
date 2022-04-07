public class Solution {
    public int LastStoneWeight(int[] stones) {
        var stonesList = stones.ToList();
        while (stonesList.Count > 1) {
            stonesList = compareTwoHeaviest(stonesList);
        }
               
       return stonesList.Count == 0 ? 0 : stonesList[0];
    }
    
    public List<int> compareTwoHeaviest(List<int> stones) {
        stones.Sort();
        if (stones[stones.Count - 1] == stones[stones.Count - 2])
        {
            stones.RemoveAt(stones.Count - 1);
            stones.RemoveAt(stones.Count - 1);
        } else {
            stones[stones.Count - 1] = stones[stones.Count - 1] - stones[stones.Count - 2];
            stones.RemoveAt(stones.Count - 2);
        }
        return stones;
    }
}