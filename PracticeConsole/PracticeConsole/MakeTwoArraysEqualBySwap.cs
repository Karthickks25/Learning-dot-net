using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class MakeTwoArraysEqualBySwap
    {
        public static void MainCall()
        {
            var a = new int[]{ 1, 0, 1, 1 };
            var b = new int[]{ 1, 1, 0, 1 };
            var count = 0;

            for(int i = 0; i < b.Length; i++)
            {
                if(a[i] == b[i])
                {
                    continue;
                }
                var toFind = b[i];
                var swapIndex = Array.IndexOf(a, toFind);
                b[i] = b[swapIndex];
                b[swapIndex] = toFind;
                count++;
            }
            Array.ForEach(a, x=>Console.Write(x));
            Console.WriteLine();
            Array.ForEach(b, x=>Console.Write(x));
            Console.WriteLine();

            Console.WriteLine("Min no of swap needed = " + count);
            Console.ReadKey();
        }

    }
}
