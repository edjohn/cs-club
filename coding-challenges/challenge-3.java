class Solution {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        
        int maxCandies = 0;
        List<Boolean> candyIsGreatest = new ArrayList<Boolean>();
        
        for (int i = 0; i < candies.length; i++)
        {
            if (candies[i] > maxCandies)
            {
                maxCandies = candies[i];
            }
        }
        for (int i = 0; i < candies.length; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
            {
                candyIsGreatest.add(true);
            }
            else
            {
                candyIsGreatest.add(false);
            }
        }
        return candyIsGreatest;
    }
}
