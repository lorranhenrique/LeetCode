public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> kvps = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(kvps.ContainsKey(diff))
                return new int[] { i, kvps[diff] };

            kvps[nums[i]] = i;
        }
        return new int[] { };
    }
}