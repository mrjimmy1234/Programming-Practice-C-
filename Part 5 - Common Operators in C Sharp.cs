using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Common_Operators_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Operators
            int i = 10;
            bool b = true;

            //Arithmetic Operators
            // %, /, *, -, +
            int Numerator = 10;
            int Denominator = 2;

            int Result = Numerator / Denominator;
            Console.WriteLine("Result = {0}", Result);

            //Comparison Operators
            // ==, !=, >, >=, <, <=
            int Number = 10;

            if (Number == 10)
            {
            }

            //Conditional Operators
            // &&, ||
            // && just means and, nice and simple, || means if any of the conditions are true it will execute the statement.
            int Number_2 = 10;
            int Another_Number = 20;

            if (Number == 10 && Another_Number == 20)
            {
                Console.WriteLine("Hello");
            }

            //Ternary Operator
            // ?:
            int Number = 10;
            bool ISNumber10;

            if (Number == 10
            {
                ISNumber10 = true;
            }
            else
            {
                ISNumber10 = false;
            }

            Console.WriteLine("Number == 10 {0}", ISNumber10);

        }
    }
}
