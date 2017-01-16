using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_14___Working_with_Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myvalue = DateTime.Now;
            //Console.WriteLine(myvalue.ToString());
            //Console.WriteLine(myvalue.ToShortDateString());
            //Console.WriteLine(myvalue.ToShortTimeString());
            //Console.WriteLine(myvalue.ToLongDateString());
            //Console.WriteLine(myvalue.ToLongTimeString());

            //Console.WriteLine(myvalue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myvalue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myvalue.AddSeconds(3).ToLongTimeString());

            //DateTime MyBirthday = new DateTime(1999, 4, 12);
            //Console.WriteLine(MyBirthday.ToShortDateString());

            DateTime MyBirthday = DateTime.Parse("12/4/1999");
            TimeSpan MyAge = DateTime.Now.Subtract(MyBirthday);
            Console.WriteLine(MyAge.TotalDays);

            Console.ReadLine();
        }
    }
}
