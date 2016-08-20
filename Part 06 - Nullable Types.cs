using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non nullable data types
            string Name = null;
            int i = null;
            bool AreYouMajor = true;

            //Nullable data type
            int? i = null;
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.Write("User did not answer the question");
            }

            //Null Coalescing Operator
            int? Tickets_On_Sale = null;

            int Available_Tickets = Tickets_On_Sale ?? 0;
            //If tickets on sale is null then use the value given
            
            Console.WriteLine("Available_Tickets = {0}, Available_Tickets")
        }
    }
}
