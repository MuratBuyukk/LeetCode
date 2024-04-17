using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_LenghtOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "   fly me   to   the moon  ";
            Console.WriteLine(LengthOfLastWord(s));
            Console.ReadLine();
        }

        public static int LengthOfLastWord(string s)
        {

            string[] lastWord = s.Trim().Split(' ');
            return lastWord[lastWord.Length - 1].Length;
        }
    }
}
