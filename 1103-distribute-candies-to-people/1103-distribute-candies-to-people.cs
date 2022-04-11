public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int n = 0;
        int[] people = new int[num_people];
        while (candies > 0) {
            for (int i = 0; i < num_people && candies > 0; i++) {
                if (candies < n + 1)
                    people[i] += candies;
                else 
                    people[i] += n + 1;
                n++;
                candies -= n;
            }
        }
        return people;
    }
}