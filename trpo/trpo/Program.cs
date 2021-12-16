using System;

namespace trpo
{
    class Program
    {
        class A
        {

        }

        class B : A
        {
            public object a;
            public object b;
        }

        class C : B
        {
            public static void Main()
            {
                A a1 = new A();
                B b2 = new B();
                B b3 = new B();
                B b4 = new B();
                C c5 = new C();

                b2.a = a1;
                b3.a = a1;
                b4.a = b2;
                c5.a = b4;
                c5.b = b3;
            }
        }
    }
}
