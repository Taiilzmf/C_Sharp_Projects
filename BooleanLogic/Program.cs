using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {   
            //asks age and converts to int
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int personsAge = Convert.ToInt32(yourAge);

            //asks for duis and converts to boolean
            Console.WriteLine("Have you ever had a DUI? True or False:");
            string yourDui = Console.ReadLine();
            bool personsDui = Convert.ToBoolean(yourDui);

            //asks how many speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string yourSpeed = Console.ReadLine();
            int personsSpeed = Convert.ToInt32(yourSpeed);

            //makes sure person is older than 15, has no duis, and has 3 or less speeding tickets
            bool isApproved = (personsAge > 15 && personsDui == false && personsSpeed <= 3);
            // prints qualified or not
            Console.WriteLine("Qualified?");
            Console.WriteLine(isApproved);






            Console.ReadLine();
        }
    }
}
