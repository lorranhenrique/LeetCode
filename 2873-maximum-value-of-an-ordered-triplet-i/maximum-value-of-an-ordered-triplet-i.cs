public class Solution {
    public long MaximumTripletValue(int[] nums) {
        
        long result = 0;
        int max = 0, maxDiff = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            result = Math.Max(result, (long)maxDiff * nums[i]);
            maxDiff = Math.Max(maxDiff, max - nums[i]);
            max = Math.Max(max, nums[i]);
        }
        return result;
    }
}