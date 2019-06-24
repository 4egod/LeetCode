using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];

            if (map.ContainsKey(x))
            {
                return new int[] { map[x], i };
            }

            map.TryAdd(nums[i], i);
        }

        return null;
    }
}