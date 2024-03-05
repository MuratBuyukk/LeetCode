using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28_Find_IndexOfThe_FirstOccurence
{
//Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
//Example 1:
//Input: haystack = "sadbutsad", needle = "sad"
//Output: 0
//Explanation: "sad" occurs at index 0 and 6.
//The first occurrence is at index 0, so we return 0.
//Example 2:
//Input: haystack = "leetcode", needle = "leeto"
//Output: -1
//Explanation: "leeto" did not occur in "leetcode", so we return -1.
//Constraints:
//1 <= haystack.length, needle.length <= 104
//haystack and needle consist of only lowercase English characters.


    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "leetcode";
            string s2 = "leeto";
            Console.WriteLine(StrStr(s1,s2));
            Console.ReadLine();
        }
        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

    }
}
