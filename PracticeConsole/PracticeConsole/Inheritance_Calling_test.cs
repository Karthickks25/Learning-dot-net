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
            //read only applies only on Fields
            //Can be defined on declaration and in constructor
            readonly int readOnlyC  = 100;

            //can only be defined on declaration and nonchangeable.
            const double constC = 3.14;

            public C()
            {
                readOnlyC = 140;
                Console.WriteLine("From Class C Constructor");
            }

            static C()
            {
                Console.WriteLine("From Class C Static Constructor");
            }

            public new void M1()
            {
                Console.WriteLine(readOnlyC);
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
            A a = new B();
            a.M1();
        }
    }
}
