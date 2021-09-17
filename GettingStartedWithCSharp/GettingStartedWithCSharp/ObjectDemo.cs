using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. what is Object Type.
    class ObjectDemo
    {
        static void Main()
        {
           
            object numObject = 100;
            object strObject = "Hello";
            object charObject = 'A';
            object boolObject = true;

            Console.WriteLine("number={0}\tstring={1}\tchar={2}\tbool={3}",numObject,strObject,charObject,boolObject);
            Console.WriteLine("The sum of {0} and {1} is {2}",30,50,30+50);
            Console.ReadLine();
        }
    }
}
