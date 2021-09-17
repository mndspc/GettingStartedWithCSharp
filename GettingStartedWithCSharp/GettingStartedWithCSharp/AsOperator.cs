using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to use as operator.
    class AsOperator
    {
        static void Main()
        {
            //  as operator is used to perform conversion between compatible reference types or Nullable types.
            object[] myObjects = {"String1","String2","String3" };
            string myStr = myObjects[1] as string;
            Console.WriteLine(myStr);
            Console.ReadLine();
        }
    }
}
