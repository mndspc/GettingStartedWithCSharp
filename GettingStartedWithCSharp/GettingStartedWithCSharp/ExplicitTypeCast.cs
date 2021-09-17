using System;

namespace GettingStartedWithCSharp
{
    //  This program demo. how to perform explicit type casting/manual type casting
    class ExplicitTypeCast
    {
        static void Main()
        {
            double d = 34.7;
            //  Explicit type cast
            //int num =(int) d;

            int num = Convert.ToInt32(d);

            string str = "100";
            int numStr = Convert.ToInt32(str);

            //  Unboxing
            object myObj = 80;
            int num1 = (int)myObj;

            Console.WriteLine(num);
            Console.WriteLine(numStr);
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
