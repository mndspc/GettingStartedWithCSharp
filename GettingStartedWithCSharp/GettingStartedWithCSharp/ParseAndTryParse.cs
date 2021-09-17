using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to convert string value into an integer.
    class ParseAndTryParse
    {
        static void Main()
        {
            //  int.TryParse is use to convert sting into an integer
            string intStr = "1233";
            int num = int.Parse(intStr);
            Console.WriteLine("After converting string into an integer using int.Prase():{0}",num);

            //  int.TryParse is use to convert string into an integer by checking its compatability
            string intStr2 = "a100";
            int num1;
            bool flag = int.TryParse(intStr2, out num1);
            if (flag)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
            Console.ReadLine();
        }
    }
}
