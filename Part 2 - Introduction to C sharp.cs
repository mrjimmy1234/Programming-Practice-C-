using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2___Introduction_to_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        
            //Console.WriteLine("Hello " + UserName);


        }
    }
}
