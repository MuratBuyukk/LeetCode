using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205_Isomorphic_Strings
{
    internal class Program
    {
//        Given two strings s and t, determine if they are isomorphic.
//        Two strings s and t are isomorphic if the characters in s can be replaced to get t.
//        All occurrences of a character must be replaced with another character while preserving the order of characters.
//        No two characters may map to the same character, but a character may map to itself.
       static void Main(string[] args)
        {
            string s = "badc";
            string t = "baba";
            Console.WriteLine(IsIsomorphic(s,t));
            Console.ReadLine();
        }

        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char,char> dict = new Dictionary<char,char>();
            for(int i = 0; i<s.Length;i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                if (!dict.ContainsKey(sChar))
                {
                    if (dict.ContainsValue(tChar))
                        return false;
                    dict.Add(sChar, tChar);
                }
                else
                {
                    if(tChar != dict[s[i]])
                        return false;
                }
            }
            return true;
        }
    }
}
