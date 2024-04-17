using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_GroupAnagrams
{
    internal class Program
    {
        /*
        Given an array of strings strs, group the anagrams together.You can return the answer in any order.
        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:
        Input: strs = ["eat","tea","tan","ate","nat","bat"]
            Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
        Example 2:
        Input: strs = [""]
            Output: [[""]]
        Example 3:
        Input: strs = ["a"]
            Output: [["a"]]
        */
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> groupedAnagrams = GroupAnagrams(strs);
            foreach (var group in groupedAnagrams)
            {
                Console.WriteLine("[" + string.Join(", ", group) + "]");
            }
            Console.ReadLine();
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == 0) return new List<IList<string>>();
            Dictionary<string, List<String>> dict = new Dictionary<string, List<String>>();
            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            return new List<IList<string>>(dict.Values);
        }

    }
}
