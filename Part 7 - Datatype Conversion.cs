using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7___Datatypes_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion
            int A = 100;
            float f = A;
            Console.WriteLine(f);

            //Explicit Conversion
            float B = 123.45F;
            int C = (int)B;
            //int C = Convert.ToInt32(B);
            Console.WriteLine(B);

            //Parse
            string strNumber = "100";
            int i = int.Parse(strNumber);
            Console.WriteLine(i);

            //TryParse
            string strNumber1 = "100TG";
            int Result = 0;
            bool Is_Conversion_Successfull = int.TryParse(strNumber1, out Result);
            if (Is_Conversion_Successfull) 
            {
                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
