using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TopInterview150
{

    //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
    //and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

    //The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    //To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
    //and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    public class _88_Merge_Sorted_Array
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1,2,3,0,0,0};
            int[] nums2 = {2,5,6};
            Merge(nums1,3, nums2,3);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[i - m];
            }

            Array.Sort(nums1);
            foreach (int i in nums1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
