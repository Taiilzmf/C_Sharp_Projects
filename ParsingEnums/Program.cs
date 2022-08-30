using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for current day stores in day
            Console.WriteLine("Please enter the current day of the week:");
            string day = Console.ReadLine();

            //try catch block 
            try
            {
                //parses user input to enum days
                Days today = (Days)Enum.Parse(typeof(Days), day);

                Console.WriteLine("Happy " + today + "!");
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message + "\nPlease enter an actual day of the week.");
            }

            Console.ReadLine();
        }





            //enum for days of the week
            public enum Days
            {
                Sunday,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday
            }
        
    }
}
