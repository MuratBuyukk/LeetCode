using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _169_Majority_Element
{
    public class Program
    {
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.
        //You may assume that the majority element always exists in the array.
        static void Main(string[] args)
        {
            int[] nums = { 3, 3, 4 };

            Console.WriteLine(MajorityElement(nums));
            Console.ReadLine();
        }

        public static int MajorityElement(int[] nums)
        {
            int n = nums.Length;
            int majortiy = 0;
            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                for (int j = 0; j < n; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter++;
                    }
                }
                if(counter > (n / 2))
                {
                    majortiy = nums[i];
                    break;
                }
            }
            return majortiy;
        }
    }
}
