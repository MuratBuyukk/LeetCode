using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242_ValidAnagram
{
    internal class Program
    {
        /*Given two strings s and t, return true if t is an anagram of s, and false otherwise.

        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        Example 1:

        Input: s = "anagram", t = "nagaram"
        Output: true
        Example 2:

        Input: s = "rat", t = "car"
        Output: false
        */
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(IsAnagram(s, t));
            Console.ReadLine();
        }

        public static bool IsAnagram(string s, string t)
        {
            char[] arrayS = s.ToCharArray();
            char[] arrayT = t.ToCharArray();
            Array.Sort(arrayS);
            Array.Sort(arrayT);
            return arrayS.SequenceEqual(arrayT);
        }
    }
}
