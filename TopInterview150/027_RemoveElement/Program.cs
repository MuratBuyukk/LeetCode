using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_RemoveElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int value = 3;

            int result = RemoveElement(nums, value);

            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }

            Array.Resize(ref nums, counter);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            return counter;
        }
    }
}
