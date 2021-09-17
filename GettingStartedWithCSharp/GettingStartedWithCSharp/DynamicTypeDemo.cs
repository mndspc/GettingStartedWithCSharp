using System;

namespace GettingStartedWithCSharp
{
    //  This program demo. how to use dynamic types
    class DynamicTypeDemo
    {
        static void Main()
        {
            //type checking for dynamic types of variables takes place at run-time
            int num = 30;
            char c = 'B';
            Console.WriteLine(num.GetType());
            dynamic dynInt = 40;
            dynamic dynStr = "Hello";
            Console.WriteLine("Int={0}\tString={1}",dynInt,dynStr);
            Console.WriteLine("Type of dynInt={0}\tdynStr={1}",dynInt.GetType(),dynStr.GetType());


            Console.ReadLine();

        }
    }
}
