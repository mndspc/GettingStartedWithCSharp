using System;
using System.Data.SqlClient;
namespace GettingStartedWithCSharp
{
    // Class and Method names should always be in PascalCase.
    class MyClass
    {
        public void MyFunction(string userName)
        {
            // Method argument and Local variables should always be in Camel Case.
            string myName = "scott";

            // Avoid the use of underscore while naming identifiers.
            string my_name = "scott";

            // Constants should always be declared in UPPER_CASE.
            double PI = 3.14;

            // For better code indentation and readability always align the curly braces vertically.
            if (true)
            {
                if (true)
                {
                    //Always declare the variables as close as possible to their use.
                    string name = "tiger";
                    Console.WriteLine(name);
                }
            }
            // Always use the using keyword when working with disposable types.It automatically disposes the object when program flow leaves the scope.
            using (SqlConnection sqlConnection=new SqlConnection())
            {
                // your logic goes here
            }
            
        }
        static void Main(string[] args)
        {
            int num;//Int32
            // Avoid the use of System data types and prefer using the Predefined data types.
            Int32 num1 = 40;
            

        }
    }

    // Always prefix an interface with letter I.
    interface IFirst
    {

    }
}
