public class Solution {
    public int LastStoneWeight(int[] stones) {
        while (stones.Length > 1) {
            stones = compareTwoHeaviest(stones);
        }
               
       return stones.Length == 0 ? 0 : stones[0];
    }
    
    public int[] compareTwoHeaviest(int[] stones) {
        List<int> stonesList = stones.OrderBy(b => b).ToList();
        if (stones[stones.Length - 1] == stones[stones.Length - 2])
        {
            stonesList.RemoveAt(stones.Length - 1);
            stonesList.RemoveAt(stones.Length - 2);
        } else {
            stonesList[stones.Length - 1] = stonesList[stones.Length - 1] - stonesList[stones.Length - 2];
            stonesList.RemoveAt(stones.Length - 2);
        }
        return stonesList.ToArray();
    }
}