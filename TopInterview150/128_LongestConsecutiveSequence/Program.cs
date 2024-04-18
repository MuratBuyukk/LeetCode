using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128_LongestConsecutiveSequence
{
    internal class Program
    {
        /*Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
        You must write an algorithm that runs in O(n) time.

        Example 1:
        Input: nums = [100,4,200,1,3,2]
        Output: 4
        Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        Example 2:
        Input: nums = [0,3,7,2,5,8,4,6,0,1]
        Output: 9
        */
        static void Main(string[] args)
        {
            int[] numbers = { 0 };
            Console.WriteLine(LongestConsecutive(numbers));
            Console.ReadLine();

        }

        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            HashSet<int> set = new HashSet<int>(nums);
            int counter = 1;
            int answer = 0;
            foreach (int num in set)
            {
                if (set.Contains(num - 1)) continue;
                int temp = num;
                counter = 1;
                while (set.Contains(temp + 1))
                {
                    temp++;
                    counter++;
                }
                answer = Math.Max(answer, counter);
            }
            return answer;
        }
    }
}
