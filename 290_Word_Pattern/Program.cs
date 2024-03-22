using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _290_Word_Pattern
{
    internal class Program
    {
        /*Given a pattern and a string s, find if s follows the same pattern.
        Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
        Example 1:
        Input: pattern = "abba", s = "dog cat cat dog"
        Output: true
        Example 2:
        Input: pattern = "abba", s = "dog cat cat fish"
        Output: false
        Example 3:
        Input: pattern = "aaaa", s = "dog cat cat dog"
        Output: false 
        */
        static void Main(string[] args)
        {
            string pattern = "aba";
            string s = "dog cat cat";
            Console.WriteLine(WordPattern(pattern,s));
            Console.ReadLine();
        }

        public static bool WordPattern(string pattern, string s)
        {
            Dictionary<char,string> dict = new Dictionary<char, string>();
            string[] strArray = s.Split(' ');
            if(pattern.Length != strArray.Length)
                return false;
            for(int i = 0; i<pattern.Length; i++)
            {
                char key = pattern[i];
                string value = strArray[i];
                if (!dict.ContainsKey(key)) { 
                    if(dict.ContainsValue(value)) 
                        return false;
                    else  
                        dict.Add(key, value);
                }
                else
                {
                    if (dict[key] != value)
                        return false;
                }
            }
            return true;
        }
    }
}
