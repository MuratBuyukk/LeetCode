public class Program
{
    public static void Main(string[] args)
    {
        int[] example1 = {2, 3, 1, 1, 4 };
        int[] example2 = {2, 3, 0, 1, 4 };


        Console.WriteLine(Solution.Jump(example1) == 2 ? "Example 1 Passed..!" : "Example 1 Failed..!");
        Console.WriteLine(Solution.Jump(example2) == 2 ? "Example 2 Passed..!" : "Example 2 Failed..!");

    }
}
