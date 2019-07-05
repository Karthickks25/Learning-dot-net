using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    public class A
    {
        static A()
        {
            Console.WriteLine("static constructor A");
        }

        public A()
        {
            Console.WriteLine("public constructor A");
        }

        ~A()
        {
            Console.WriteLine("public destructor ~A");
        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("static constructor B");
        }

        public B()
        {
            Console.WriteLine("public constructor B");
        }
        
         ~B()
        {
            Console.WriteLine("public destructor ~B");
        }

        public void Test()
        {
            Console.WriteLine("Test method call");
        }
    }

    public class StaticConstructorTest
    {
        public static void MainCall()
        {
            B a = new B();
            a.Test();
            Console.ReadLine();
        }
    }
}
