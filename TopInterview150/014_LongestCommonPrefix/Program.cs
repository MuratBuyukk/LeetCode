using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] srtArray = { "abab", "aba", "abc" };
            Console.WriteLine(LongestCommonPrefix(srtArray));
            Console.ReadLine();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
            string answer = "";
            bool isOk = false;
            if (strs.Length == 1)
                return answer += strs[0];
            for (int i = 0; i < strs[0].Length; i++)
            {
                char temp = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] == temp)
                    {
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                        break;
                    }
                }
                if (isOk)
                {
                    answer += temp;
                }
                else
                {
                    break;
                }
            }
            return answer;
        }
    }
}
