using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_Ransom_Note
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ransom = "aa";
            string mag = "aab";
            Console.WriteLine(CanConstruct(ransom,mag));
            Console.ReadLine();
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            for(int i = 0; i<ransomNote.Length; i++)
            {
                int index = magazine.IndexOf(ransomNote[i]);
                if(index == -1)
                    return false;
                else
                    magazine = magazine.Remove(index,1);
            }
            return true;
        }
    }
}
