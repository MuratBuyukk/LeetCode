public class Solution
{
    public static int HIndex(int[] citations)
    {
        var sortedCitations = citations.OrderByDescending(c => c).ToArray();

        int hIndex = 0;
        for (int i = 0; i < sortedCitations.Length; i++)
        {
            if (sortedCitations[i] >= i + 1) hIndex++;
            else break;
        }
        return hIndex;
    }
}