public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int a = x, y = 0, z = 0;

        do
        {
            y = x % 10;
            x /= 10;

            if (z > int.MaxValue / 10 || (z == int.MaxValue / 10 && y > 7)) return false;
            if (z < int.MinValue / 10 || (z == int.MinValue / 10 && y < -8)) return false;

            z *= 10;
            z += y;

        } while (x != 0);

        return a == z;
    }
}