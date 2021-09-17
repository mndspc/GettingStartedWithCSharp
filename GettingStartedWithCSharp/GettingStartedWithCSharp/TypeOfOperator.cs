using System;

namespace GettingStartedWithCSharp
{
    //  This program demo. how to use typeof operator
    class TypeOfOperator
    {
        static void Main()
        {
            //  typeof is used to find out the managed type of type at run time
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(string));
            Console.ReadLine();
        }
    }
}
