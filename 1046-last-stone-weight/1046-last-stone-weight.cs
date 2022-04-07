public class Solution {
    public int LastStoneWeight(int[] stones) {
        var stonesList = stones.ToList();
        stonesList = stones.OrderByDescending(b => b).ToList();
        while (stonesList.Count > 1) {
            stonesList = compareTwoHeaviest(stonesList);
        }
               
       return stonesList.Count == 0 ? 0 : stonesList[0];
    }
    
    public List<int> compareTwoHeaviest(List<int> stones) {
        if (stones[0] == stones[1])
        {
            stones.RemoveAt(0);
            stones.RemoveAt(0);
        } else {
            var remainingStone = stones[0] - stones[1];
            stones.RemoveAt(0);
            stones.RemoveAt(0);
            for (var i = 0; i < stones.Count; i++) {
                if (remainingStone > stones[i]) {
                    stones.Insert(i, remainingStone);
                    i = stones.Count + 1;
                    remainingStone = -1;
                }
            }
            if (remainingStone > 0)
                stones.Add(remainingStone);
        }
        return stones;
    }
}