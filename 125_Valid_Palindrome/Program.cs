using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _125_Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(str));
            Console.ReadLine();
        }

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            s = Regex.Replace(s, "[^a-z0-9]+", "");
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
