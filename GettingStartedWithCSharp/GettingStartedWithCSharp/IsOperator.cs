using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to use is operator.
    class IsOperator
    {
        static void Main()
        {
            //  The is operator returns true if the given object is of the same type.
            A a = new A();
            Console.WriteLine(a is B);
            B b = new B();
            Console.WriteLine(b is A);
            Console.ReadLine();
        }
    }
    class A
    {

    }
    class B:A
    {

    }
}
