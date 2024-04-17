using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "DCXXI";
            Console.WriteLine(RomanToInt(text));
            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            int sum = 0;
            int prev = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int value = (int)Enum.Parse(typeof(Romans), s[i].ToString());
                if (value < prev)
                {
                    sum -= value;
                }
                else
                {
                    sum += value;
                }
                prev = value;
            }

            return sum;
        }

        enum Romans
        {
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        }
    }
}
