using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_13___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target");
            int User_Target = int.Parse(Console.ReadLine());

            int Start = 0;
            while(Start <= User_Target)
            {
                Console.WriteLine(Start + " ");
                Start = Start + 2;
            }
        }
    }
}
