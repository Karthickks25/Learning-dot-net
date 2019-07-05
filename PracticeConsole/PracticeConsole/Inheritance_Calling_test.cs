using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class Inheritance_Calling_test
    {
        class A
        {
            public A()
            {
                Console.WriteLine("From Class A Constructor");
            }

            static A()
            {
                Console.WriteLine("From Class A Static Constructor");
            }

            public virtual void M1()
            {
                Console.WriteLine("M1 called from Class A");
            }
        }

        class B : A
        {
            public B()
            {
                Console.WriteLine("From Class B Constructor");
            }

            static B()
            {
                Console.WriteLine("From Class B Static Constructor");
            }

            public override void M1()
            {
                Console.WriteLine("M1 called from Class B");
            }
        }

        class C : B
        {
            public C()
            {
                Console.WriteLine("From Class C Constructor");
            }

            static C()
            {
                Console.WriteLine("From Class C Static Constructor");
            }

            public override void M1()
            {
                var b = 20;
                dynamic a = 10;
                Console.WriteLine($"{a}, {b}");

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine($"{a}, {b}");
                Console.WriteLine("M1 called from Class C");
            }
        }

        public static void MainCall()
        {
            A a = new C();
            a.M1();
        }
    }
}
