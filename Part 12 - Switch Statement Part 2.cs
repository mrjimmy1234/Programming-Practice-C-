using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_12___Switch_Statement_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total_Cost = 0;
            Start:
            Console.WriteLine("Please select your coffee size: 1 - Small, 2 - Medium, 3 - Large");
            int User_Choice = int.Parse(Console.ReadLine());
            switch(User_Choice)
            {
                case 1:
                    Total_Cost += 1;
                    break;
                case 2:
                    Total_Cost += 2;
                    goto case 1;
                case 3:
                    Total_Cost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", User_Choice);
                    goto Start;
            }
            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No?");
            string User_Decision = Console.ReadLine();

            switch(User_Decision.ToUpper())
            {
                case "Yes":
                    goto Start;
                case "No":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", User_Decision);
                    goto Decide;
            }
            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill amount = {0}", Total_Cost);
        }
    }
}
