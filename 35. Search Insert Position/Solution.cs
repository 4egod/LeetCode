public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, g = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) return i;

            if (nums[i] < target) l = i + 1;

            if (nums[i] > target)
            {
                g = i;
                break;
            }
        }

        if (l == 0 && g == 0) return 0;

        if (g == 0) return nums.Length;

        if (g > 0) return g;

        return 0;
    }
}