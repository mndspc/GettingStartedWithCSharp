using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to perform implicit conversion.
    class ImplicitTypeCast
    {
        static void Main()
        {
            int num = 10;
            //  implicit conversion
            double d = num;
            //  implicite conversion (boxing)
            object intObj = num;

            Console.WriteLine("num={0}\t intObj={1}",num,intObj);
            Console.ReadLine();
        }
    }
}
