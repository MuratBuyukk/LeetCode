public class Solution
{
    public static int Jump(int[] nums)
    {
        int jumpCount = 0;
        int jumpRange = 0;
        int maxRange = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            maxRange = Math.Max(maxRange, i + nums[i]);
            if (jumpRange == i)
            {
                jumpCount++;
                jumpRange = maxRange;
            }
        }
        return jumpCount;
    }
}