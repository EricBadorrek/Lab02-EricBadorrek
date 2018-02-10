using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_EricBadorrek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 2: Accept 2 inputs from the command prompt.  Output their sum.

            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first number: "); // prompt user 
            // read first number from user
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: "); // prompt user
            // read second number from user
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2; // add numbers

            Console.WriteLine($"Sum of the two numbers = {sum}"); // display sum

           // Question 3: Create 3 variables: x, y and z.  Assign integer values to them.  Output the solution to the following expression: (x + y) * (z + 10)

            int x = 1;
            int y = 2;
            int z = 3;
            int result;
            result = (x + y) * (z + 10);
            Console.WriteLine("If: x = 1, y = 2, z = 3\nWhat is the solution to: (x+y)*(z+10) = ");
            Console.WriteLine(result);

            // Question 4: Output the following messages using escape sequences: 
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");
        }
    }
}
