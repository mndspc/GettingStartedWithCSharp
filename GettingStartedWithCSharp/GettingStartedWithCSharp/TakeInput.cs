using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to take input from user
    class TakeInput
    {
        static void Main()
        {
            Console.Write("Enter First Number1:");
            int num1 =int.Parse( Console.ReadLine());

            Console.Write("Enter Second Number2:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum of number1:{0} and number2:{1} is {2}",num1,num2,sum);
            Console.ReadLine();
        }
    }
}
