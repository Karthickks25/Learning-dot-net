using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class FindAndRemoveConsecutiveCharacter
    {
        public static void Maincall()
        {
            var output = "";
            Find(3, "abbcccb", ref output);
            Console.WriteLine(output);
            Find(2, "baac", ref output);
            Console.WriteLine(output);
        }

        public static void Find(int K, string input, ref string output)
        {
            char[] charArr = input.ToCharArray();

            int count = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr.Length < K)
                {
                    break;
                }
                if (i == 0)
                {
                    count = 1;
                    output = input;
                    continue;
                }
                if (charArr[i] == charArr[i - 1])
                {
                    count++;

                    if (count == K)
                    {
                        output = input.Remove(i - (K - 1), K);
                        char[] trimmedChar = output.ToCharArray();
                        if (trimmedChar.Length < K)
                        {
                            Find(K, output, ref output);
                        }
                        else
                        {
                            Find(K, output, ref output);
                        }
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}
