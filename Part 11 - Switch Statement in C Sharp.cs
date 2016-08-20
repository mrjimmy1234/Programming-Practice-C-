using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_11___Switch_Statement_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int User_Number = int.Parse(Console.ReadLine());
            if(User_Number == 10)
            {
                Console.WriteLine("Your number is 10");
            }
            else if(User_Number == 20)
            {
                Console.WriteLine("Your number is 20");
            }
            else if(User_Number == 30)
            {
                Console.WriteLine("Your number is 30");
            }
            else
            {
                Console.WriteLine("Your number is not 10, 20 or 30");
            }

            //All of the code above can be replaced with the code below to reduce size and increase efficiency.

            switch(User_Number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", User_Number);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20 or 30");
                    break;

             //Reduced from 16 lines to 10.
            }
        }
    }
}
