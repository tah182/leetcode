public class Solution {
    public int TotalFruit(int[] fruits) {
        if (fruits.Length <= 2) return fruits.Length;
        
        var max = 0;
        for (int i = 0; i < fruits.Length - 1; i++) {
            if (fruits.Length - i < max) break;
            HashSet<int> fruitTypes = new HashSet<int>();
            var counter = 0;
            for (int j = i; j < fruits.Length; j++) {
                if (fruitTypes.Count < 2) {
                    counter++;
                    fruitTypes.Add(fruits[j]);
                } else if (fruitTypes.Contains(fruits[j]))
                    counter++;
                else 
                    break;
            }
            max = max > counter ? max : counter;
        }
        return max;
    }
}