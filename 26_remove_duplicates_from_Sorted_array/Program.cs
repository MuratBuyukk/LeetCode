using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_remove_duplicates_from_Sorted_array
{
    //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
    //The relative order of the elements should be kept the same.Then return the number of unique elements in nums.
    //Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
    //Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.
    //The remaining elements of nums are not important as well as the size of nums. Return k.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2 };
            int[] expectedNums = { 1, 2 }; 

            int k = removeDuplicates(nums);

            Console.WriteLine(k);
            Console.ReadLine();
        }

        static public int removeDuplicates(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                bool isHas = false;
                Console.WriteLine("i =" + nums[i]);
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isHas = true;
                        break;
                    }
                }
                Console.WriteLine("isHas: " + isHas);
                if (isHas == false)
                {
                    nums[counter] = nums[i];
                    counter++;
                }
            }
            Array.Resize(ref nums, counter);
            return nums.Length;
        }
    }
}
