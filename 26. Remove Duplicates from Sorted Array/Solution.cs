public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int c = 0, k = 1;

        for (int i = 0; i < nums.Length - 1 - c; i++)
        {
            for (int j = k; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    c++;
                }
                else
                {
                    nums[i + 1] = nums[j];
                    k = j + 1;
                    break;
                }
            }
        }

        return nums.Length - c;
    }
}