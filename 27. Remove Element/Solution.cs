public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int c = 0;
        for (int i = 0; i <= nums.Length - 1 - c; i++)
        {
            if (nums[i] == val)
            {
                for (int j = nums.Length - 1 - c; j >= 1; j--)
                {
                    if (i == j)
                    {
                        break;
                    }

                    if (nums[j] == val)
                    {
                        c++;
                        continue;
                    }
                    else
                    {
                        nums[i] = nums[j];
                        break;
                    }
                }

                c++;
            }
        }

        return nums.Length - c;
    }
}