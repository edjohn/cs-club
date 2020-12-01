class Solution {
    public int[] shuffle(int[] nums, int n) {
        int[] vals = new int[2*n];
        for (int i = 0, j = 0; i < 2*n; i += 2, j++)
        {
            vals[i] = nums[j];
            vals[i+1] = nums[n + j];
        }
        return vals;
    }
}
