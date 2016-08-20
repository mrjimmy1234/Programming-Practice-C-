using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_10____If_Statements_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int User_Number = int.Parse(Console.ReadLine());
            if(User_Number == 1)
            {
                Console.WriteLine("Your number is one");
            }
            else if(User_Number == 2)
            {
                Console.WriteLine("Your number is two");
            }
            else if(User_Number == 3)
            {
                Console.WriteLine("Your number is three");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
}
