using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class StringOccurance
    {
        public static void Maincall()
        {
            string str = "Hello World! Hello!";
            Console.WriteLine("Occurrence:" + Check.CheckOccurrences(str, "Hello"));
        }

        public static class Check
        {
            public static int CheckOccurrences(string str1, string pattern)
            {
                int count = 0;
                int a = 0;

                while ((a = str1.IndexOf(pattern, a)) != -1)
                {
                    a += pattern.Length;
                    count++;
                }
                return count;
            }
        }

    }
}
