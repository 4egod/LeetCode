public class Solution
{
    public int Reverse(int x)
    {
        int y = 0, z = 0;

        do
        {
            y = x % 10;
            x /= 10;

            if (z > int.MaxValue / 10 || (z == int.MaxValue / 10 && y > 7)) return 0;
            if (z < int.MinValue / 10 || (z == int.MinValue / 10 && y < -8)) return 0;

            z *= 10;
            z += y;

        } while (x != 0);

        if (z > int.MaxValue || z < int.MinValue)
        {
            return 0;
        }

        return z;
    }
}