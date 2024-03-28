using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 19;
            Console.WriteLine(IsHappy(n));
            Console.ReadLine();
        }

        public static bool IsHappy(int n)
        {
            HashSet<int> oldResults = new HashSet<int>();
            while (oldResults.Add(n))
            {
                int result = 0;
                while (n > 0)
                {
                    result += (int)Math.Pow(n % 10, 2.0);
                    n = n / 10;
                }
                n = result;
            }
            if (n == 1) return true;
       
            return false;
        }
    }
}
