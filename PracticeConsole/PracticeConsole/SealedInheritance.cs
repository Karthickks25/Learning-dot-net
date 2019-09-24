using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public sealed class SealedInheritance
    {
        public void m1()
        {
            Console.WriteLine("sealed class called from an instance");
        }
    }

    public static class SealedClassExample 
    {
        public static void MainCall()
        {
            SealedInheritance si = new SealedInheritance();
            si.m1();
        }
    }
}
